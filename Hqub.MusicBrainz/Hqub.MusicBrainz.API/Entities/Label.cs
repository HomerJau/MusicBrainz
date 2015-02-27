﻿using System.Xml.Serialization;

namespace Hqub.MusicBrainz.API.Entities
{
    [XmlRoot("label")]
    public class Label : Entity
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }
    }
}
