﻿using System.ComponentModel;
using System.Xml.Serialization;

namespace AnyStatus.API
{
    public interface IReportProgress
    {
        [XmlIgnore]
        [Browsable(false)]
        int Progress { get; set; }

        [XmlIgnore]
        [Browsable(false)]
        bool ShowProgress { get; set; }

        void ResetProgress();
    }
}