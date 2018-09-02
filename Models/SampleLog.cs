using System;
namespace core.log.viewer.Core
{
    public class SampleLog
    {
        public DateTime Timestamp {get; set;}
        public Severity Severity {get;set;}
        public string Text {get; set;}
    }  
}