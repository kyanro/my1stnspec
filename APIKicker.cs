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
        WebRequest request;
        string initialURI;

        /// <summary>
        /// 受け取ったURIを保存し、WebRequestクラスを作成する
        /// </summary>
        /// <param name="uri">APIのURI</param>
        public APIKicker(string uri)
        {
            initialURI = uri;
            request = WebRequest.Create(uri);
        }

        /// <summary>
        /// コンストラクタで渡されたURIを表示する
        /// </summary>
        /// <returns></returns>
        public string GetURI()
        {
            return initialURI;
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
