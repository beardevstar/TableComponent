using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterTableComponentSample.Client.Shared
{
    public class Column
    {
        public string key { get; set; }
        public string title { get; set; }
        public string filter { get; set; }
        public Column(string _key, string _title, bool _flag = true,string _filter = "")
        {
            key = _key; title = _title; filter = _filter;
        }
    }
    public class SampleObject
    {
        public string name { get; set; }
        public string email { get; set; }
        public string groupname { set; get; }
        
        public bool isreadonly { set; get; }
        public bool isselected { set; get; }
        
        public SampleObject(string _name, string _mail, string _groupname ,bool _isreadonly = false,bool _isselected = false)
        {
            name = _name; email = _mail; groupname = _groupname;
            isreadonly = _isreadonly;isselected = _isselected;
        }
    }
}
