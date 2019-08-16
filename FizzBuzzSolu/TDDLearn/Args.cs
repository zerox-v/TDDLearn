using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDLearn
{
    public class Args
    {
        private readonly string[] _argsArr;
        private readonly Schema _schema;

        public Args(string[] argsArr, Schema schema)
        {
            this._argsArr = argsArr;
            this._schema = schema;
        }

        public object GetValue(string v)
        {
            var item = _argsArr.First(o => o.Split(' ').First()== v);
            if (item != null) return GetValue(_schema.GetType(v), item);
            throw new Exception($"暂不支持命令“{v}”");
        }



        private object GetValue(string type, string value)
        {
            var arg = value.Split(" ");
            value = arg.Length == 1 ? "" : arg[1];
            switch (type)
            {
                case "bool":
                    return string.IsNullOrEmpty(value) || Convert.ToBoolean(value);
                case "int":
                    return string.IsNullOrEmpty(value) ? 0 : Convert.ToInt32(value);
                case "string":
                    return value;
                case "string-arr":
                    return string.IsNullOrEmpty(value) ?null : value.Split(','); 
                case "int-arr":
                    return string.IsNullOrEmpty(value) ? null : 
                        value.Split(',').Select(o=>Convert.ToInt32(o)).ToArray();
                default:
                    throw new Exception($"暂不支持“{type}”类型的参数");

            }

        }




    }
}
