﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace TemplateBuilder
{
    public class Template : List<PromptGroup>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        private string _RawText;
        public string RawText
        {
            set
            {
                this._RawText = value;
                loadFormConfig();
                loadTemplateText();
                loadFromXML();
            }
            get
            {
                return this._RawText;
            }
        }

        private string _FormConfigXML;
        public string FormConfigXML
        {
            set { this._FormConfigXML = value; }
            get
            {
                if ((this._FormConfigXML == string.Empty) ||
                    (this._FormConfigXML == null))
                    loadFormConfig();
                return this._FormConfigXML;
            }
        }

        private string _TemplateText;
        public string TemplateText
        {
            set { this._TemplateText = value; }
            get
            {
                if ((this._TemplateText == string.Empty) ||
                    (this._TemplateText == null))
                    loadTemplateText();
                return this._TemplateText;
            }
        }

        public string Output
        {
            get
            {
                return "<#--" + this.ToXml() + "-->" + this._TemplateText;
            }
        }

        private void loadFormConfig()
        {
            try
            {
                String startingTag = "<#--";
                String endingTag = "-->";
                int startingPosition = 0;
                int endingPosition = 0;
                startingPosition = RawText.IndexOf(startingTag) + startingTag.Length;
                endingPosition = RawText.IndexOf(endingTag);
                FormConfigXML = RawText.Substring(startingPosition, endingPosition - startingPosition);
            }
            catch (Exception e)
            {
                throw new Exception("Didn't find any XML in the first comment.", e);
            }
        }

        private void loadTemplateText()
        {
            try
            {
                TemplateText = RawText.Substring(RawText.IndexOf("-->")+3);
            }
            catch (Exception e)
            {
                throw new Exception("Didn't find the end of the xml block.", e);
            }
        }

	    public void loadFromXML()
        {
            if (FormConfigXML == string.Empty)
            {
                throw new Exception("No form config xml found.");
            }
            XmlDocument root = new XmlDocument();
            root.InnerXml = FormConfigXML;

            XmlNode templateNode = (XmlNode)root.DocumentElement;

            if (templateNode is XmlElement)
            {
                if (templateNode.HasChildNodes)
                {
                    foreach (XmlNode templateNodeChild in templateNode.ChildNodes)
                    {
                        if (templateNodeChild is XmlElement) // && (templateNodeChild.HasChildNodes))
                        {
                            if (templateNodeChild.Name == "name")
                                Name = templateNodeChild.InnerText;
                            if (templateNodeChild.Name == "description")
                                Description = templateNodeChild.InnerText;
                            //Process groups
                            if (templateNodeChild.Name == "promptgroups")
                            {
                                foreach (XmlNode groupNode in templateNodeChild.ChildNodes)
                                {
                                    if ((groupNode is XmlElement) && (groupNode.HasChildNodes))
                                    {
                                        string maxRepeats = null;
                                        try
                                        {
                                            maxRepeats = groupNode.Attributes["maxRepeats"].Value;
                                        }
                                        catch { }

                                        PromptGroup promptGroup = new PromptGroup(
                                            groupNode.Attributes["name"].Value,
                                            groupNode.Attributes["repeatable"].Value,
                                            maxRepeats);

                                        //Process prompts
                                        foreach (XmlNode promptNode in groupNode.ChildNodes)
                                        {
                                            if ((promptNode is XmlElement) && (groupNode.HasChildNodes))
                                            {
                                                promptGroup.Add(parsePrompt(promptNode, promptGroup));
                                            }
                                        }
                                        this.Add(promptGroup);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            root = null;
	    }
        
	    private Prompt parsePrompt(XmlNode promptNode, PromptGroup promptGroup)
        {
		    Prompt prompt = new Prompt();
            prompt.Parent = promptGroup;
            foreach (XmlNode promptChildNode in promptNode.ChildNodes)
            {
                if (promptChildNode.Name == "type")
                {
                    prompt.SetTypeFromString(promptChildNode.InnerText);
                    //Apply the special attributes for some types
                    parseTypeOptions(promptChildNode, prompt);
                }
                else if (promptChildNode.Name == "name")
                {
                    prompt.Name = promptChildNode.InnerText;
                }
                else if (promptChildNode.Name == "label")
                {
                    prompt.Label = promptChildNode.InnerText;
                }
                else if (promptChildNode.Name == "description")
                {
                    prompt.Description = promptChildNode.InnerText;
                }
                else if (promptChildNode.Name == "hint")
                {
                    prompt.Hint = promptChildNode.InnerText;
                }
            }
		
		    return prompt;
	    }

        private void parseTypeOptions(XmlNode typeNode, Prompt prompt)
        {
            if (prompt.Type == Prompt.PromptType.CHECKBOX)
            {
                //Read additional options
                try
                {
                    prompt.CheckedValue = typeNode.Attributes["checkedValue"].Value;
                }
                catch (Exception e)
                {
                    prompt.CheckedValue = "";
                }
                try
                {
                    prompt.UncheckedValue = typeNode.Attributes["uncheckedValue"].Value;
                }
                catch (Exception e)
                {
                    prompt.UncheckedValue = "";
                }
            }
            else if (prompt.Type == Prompt.PromptType.DATE)
            {
                //Read additional options
                try
                {
                    prompt.DateFormat = typeNode.Attributes["dateFormat"].Value;
                }
                catch (Exception e)
                {
                    prompt.DateFormat = "MM/dd/yyyy";
                }
            }
            else if (prompt.Type == Prompt.PromptType.MULTILINE)
            {
                //None
            }
            else if (prompt.Type == Prompt.PromptType.TEXT)
            {
                //None
            }
        }

        public string ToXml()
        {
            XmlDocument doc = new XmlDocument();
            
            XmlElement templateElement = (XmlElement)doc.AppendChild(doc.CreateElement("template"));
            XmlElement templateNameElement = (XmlElement)templateElement.AppendChild(doc.CreateElement("name"));
            templateNameElement.InnerText = this.Name;
            XmlElement templateDescriptionElement = (XmlElement)templateElement.AppendChild(doc.CreateElement("description"));
            templateDescriptionElement.InnerText = this.Description;
            XmlElement promptGroupsElement = (XmlElement)templateElement.AppendChild(doc.CreateElement("promptgroups"));

            foreach (PromptGroup promptGroup in this)
            {
                XmlElement promptGroupElement = (XmlElement)promptGroupsElement.AppendChild(doc.CreateElement("promptgroup"));
                promptGroupElement.SetAttribute("name", promptGroup.Name);
                if (promptGroup.Repeatable)
                {
                    promptGroupElement.SetAttribute("repeatable", "yes");
                    promptGroupElement.SetAttribute("maxRepeats", promptGroup.MaxRepeats.ToString());
                }
                else
                {
                    promptGroupElement.SetAttribute("repeatable", "no");
                }
                foreach (Prompt prompt in promptGroup)
                {
                    XmlElement promptElement = (XmlElement)promptGroupElement.AppendChild(doc.CreateElement("prompt"));
                    XmlElement typeElement = (XmlElement)promptElement.AppendChild(doc.CreateElement("type"));
                    if (prompt.Type == Prompt.PromptType.DATE)
                    {
                        typeElement.SetAttribute("dateFormat", prompt.DateFormat);
                    }
                    else if (prompt.Type == Prompt.PromptType.CHECKBOX)
                    {
                        typeElement.SetAttribute("checkedValue", prompt.CheckedValue);
                        typeElement.SetAttribute("uncheckedValue", prompt.UncheckedValue);
                    }
                    switch (prompt.Type)
                    {
                        case Prompt.PromptType.TEXT:
                            typeElement.InnerText = "text";
                            break;
                        case Prompt.PromptType.MULTILINE:
                            typeElement.InnerText = "multiline";
                            break;
                        case Prompt.PromptType.DATE:
                            typeElement.InnerText = "date";
                            break;
                        case Prompt.PromptType.CHECKBOX:
                            typeElement.InnerText = "checkbox";
                            break;
                        default:
                            typeElement.InnerText = "text";
                            break;
                    }
                    XmlElement nameElement = (XmlElement)promptElement.AppendChild(doc.CreateElement("name"));
                    nameElement.InnerText = prompt.Name;
                    XmlElement labelElement = (XmlElement)promptElement.AppendChild(doc.CreateElement("label"));
                    labelElement.InnerText = prompt.Label;
                    XmlElement descriptionElement = (XmlElement)promptElement.AppendChild(doc.CreateElement("description"));
                    descriptionElement.InnerText = prompt.Description;
                    if (prompt.Type != Prompt.PromptType.DATE)
                    {
                        XmlElement hintElement = (XmlElement)promptElement.AppendChild(doc.CreateElement("hint"));
                        hintElement.InnerText = prompt.Hint;
                    }
                }
            }

            return ToIndentedString(doc);
        }

        private string ToIndentedString(XmlDocument doc)
        {
            var stringWriter = new StringWriter(new StringBuilder());
            var xmlTextWriter = new XmlTextWriter(stringWriter) { Formatting = Formatting.Indented };
            doc.Save(xmlTextWriter);
            return stringWriter.ToString();
        }

    }
}
