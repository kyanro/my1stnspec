using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

using System.IO;


namespace KickMyAPI
{
    /// <summary>
    /// API kicker クラス
    /// </summary>
    public class APIKicker : IDisposable
    {
        private WebRequest request;

        /// <summary>
        /// 受け取ったURIをもとに WebRequestクラスを作成しておく
        /// </summary>
        /// <param name="uri">APIのURI</param>
        public APIKicker(string uri)
        {
            request = WebRequest.Create(uri);

        }

        /// <summary>
        /// リクエストをもとに文字列を取得する
        /// </summary>
        public string GetString()
        {
            using (var response = request.GetResponse())
            {
                using (var stream = new StreamReader(response.GetResponseStream()))
                {
                    return stream.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            request = null;
        }
    }
}
