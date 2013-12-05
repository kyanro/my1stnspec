using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSpec;

using KickMyAPI;

namespace KickMyAPI
{
    class my1stspec : nspec
    {
        APIKicker kapi;
        void before_each()
        {
//            kapi = new APIKicker("http://yahoo.co.jp"); 
        }
        //void コンストラクタにyahooを渡した時()
        //{
        //    it["yahooが設定される"] = () =>
        //    {
        //        before = () => kapi = new APIKicker("http://yahoo.co.jp");
        //        kapi.GetURI2().should_be("http://yahoo.co.jp");
        //    };
        //}
        void コンストラクタに_yahooを渡した時()
        {
            before = () => kapi = new APIKicker("http://yahoo.co.jp");
            it["yahooが設定される"] = () =>
            {
                kapi.GetURI2().should_be("http://yahoo.co.jp");

            };
        }
    }
}
