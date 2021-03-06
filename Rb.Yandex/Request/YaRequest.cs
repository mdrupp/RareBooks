﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace Rb.Yandex.Request
{
    [XmlRoot("request")]
    public class YaRequest
    {
        [XmlArray("groupings")]
        [XmlArrayItem("groupby")]
        public List<GroupBy> Groupings { get; set; }

        [XmlElement("maxpassages")]
        public int MaxPassages { get; set; }

        [XmlElement("page")]
        public int Page { get; set; }

        [XmlElement("query")]
        public string Query { get; set; }

        [XmlElement("sortby")]
        public SortBy SortBy { get; set; }
    }
}