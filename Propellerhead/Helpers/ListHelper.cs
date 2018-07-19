using Propellerhead.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Propellerhead.Helpers
{
    public class ListHelper
    {
        private List<KeyValuePair<string, string>> StatusList()
        {
            List<KeyValuePair<string, string>> orderList = new List<KeyValuePair<string, string>>();
            foreach (var value in Enum.GetValues(typeof(Status)))
            {
                orderList.Add(new KeyValuePair<string, string>(((int)value).ToString(), ((Status)value).ToString()));
            }
            return orderList;
        }
    }
}