using System;
using System.Collections.Generic;
using System.Text;
using TDDLearn;
using Xunit;

namespace XUnitTestProject
{
    public class SchemaTest
    {

        [Fact]
        public void Test1()
        {
            //TODO 把命令行字符串拆分成数组
            const string argsAsText = "-l -p 8080 -d /usr/logs";
            var argsArr = TDDLearn.CLIInputParse.Parse(argsAsText);

            //TODO 把字符串形式的Schema解析成对象
            var schemaAsText = "l:bool p:int d:string";
            var schema = new Schema(schemaAsText);

            //TODO 根据Schema获取参数对应的值
            var args = new Args(argsArr, schema);

            Assert.Equal(true,args.GetValue("l"));
            Assert.Equal(8080,args.GetValue("p"));
            Assert.Equal("/usr/logs", args.GetValue("d"));
        }


        [Fact]
        public void Test2()
        {
            //TODO 把命令行字符串拆分成数组
            const string argsAsText = "-l -p 8080 -g this,is,a,list -d 1,2,-3,5";
            var argsArr = TDDLearn.CLIInputParse.Parse(argsAsText);

            //TODO 把字符串形式的Schema解析成对象
            var schemaAsText = "l:bool p:int d:int-arr g:string-arr";
            var schema = new Schema(schemaAsText);

            //TODO 根据Schema获取参数对应的值
            var args = new Args(argsArr, schema);

            Assert.Equal(true, args.GetValue("l"));
            Assert.Equal(8080, args.GetValue("p"));
            Assert.Equal(new int[]{
                1,2,-3,5
            }, args.GetValue("d"));
            Assert.Equal(new string[]{
                "this","is", "a", "list"
            }, args.GetValue("g"));
        }
    }
}
