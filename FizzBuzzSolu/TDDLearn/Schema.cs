using System;
using System.Collections.Generic;

namespace TDDLearn
{
    public class Schema
    {
        private readonly Dictionary<string, string> _dic = new Dictionary<string, string>();

        public Schema(string schemaAsText)
        {
            var schema = schemaAsText.Split(' ');
            foreach (var item in schema)
            {
                var itemArr = item.Split(':');
                if (itemArr.Length != 2) throw new Exception("Schema格式不正确");
                _dic.Add(itemArr[0], itemArr[1]);
            }

        }

        public string GetType(string cmd)
        {
            return _dic[cmd];
        }

    }
}
