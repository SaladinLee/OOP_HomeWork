using System.Collections.Generic;
using Newtonsoft.Json;

namespace OOP_Lib
{
    /// <summary>
    /// 檔案類型處理方式設定類別
    /// </summary>
    public class Config
    {
        /// <summary>
        /// 副檔名類型
        /// </summary>
        private string ext;

        /// <summary>
        /// 要備份檔案的目錄
        /// </summary>
        private string location;

        /// <summary>
        /// true: 處理子目錄 false: 不處理子目錄
        /// </summary>
        private bool subDirectory;

        /// <summary>
        /// 設定備份單位，file : 單一檔案；directory : 整個目錄
        /// </summary>
        private string unit;

        /// <summary>
        /// 處理完是否刪除檔案，true : 刪除；false : 不刪除
        /// </summary>
        private bool remove;

        /// <summary>
        /// zip  : 壓縮；encode : 加密
        /// </summary>
        private string handler;

        /// <summary>
        /// 處理後要儲存到什麼地方，directory : 目錄；db : 資料庫
        /// </summary>
        private string destination;

        /// <summary>
        /// 處理後的目錄
        /// </summary>
        private string dir;

        /// <summary>
        /// 設定資料庫連接字串
        /// </summary>
        private string connectionString;

        /// <summary>
        /// 建構子
        /// </summary>
        public Config()
        {
            this.ext = string.Empty;
            this.location = string.Empty;
            this.connectionString = string.Empty;
            this.destination = string.Empty;
            this.dir = string.Empty;
            this.handler = string.Empty;
            this.remove = false;
            this.subDirectory = false;
            this.unit = string.Empty;
        }

        /// <summary>
        /// 副檔名類型
        /// </summary>
        [JsonProperty("ext")]
        public string Ext
        {
            get { return this.ext; }
            set { this.ext = value; }
        }

        /// <summary>
        /// 要備份檔案的目錄
        /// </summary>
        [JsonProperty("location")]
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        /// <summary>
        /// true: 處理子目錄 false: 不處理子目錄
        /// </summary>
        [JsonProperty("subDirectory")]
        public bool SubDirectory
        {
            get { return this.subDirectory; }
            set { this.subDirectory = value; }
        }

        /// <summary>
        /// 設定備份單位，file : 單一檔案；directory : 整個目錄
        /// </summary>
        [JsonProperty("unit")]
        public string Unit
        {
            get { return this.unit; }
            set { this.unit = value; }
        }

        /// <summary>
        /// 處理完是否刪除檔案，true : 刪除；false : 不刪除
        /// </summary>
        [JsonProperty("remove")]
        public bool Remove
        {
            get { return this.remove; }
            set { this.remove = value; }
        }

        /// <summary>
        /// zip  : 壓縮；encode : 加密
        /// </summary>
        [JsonProperty("handler")]
        public string Handler
        {
            get { return this.handler; }
            set { this.handler = value; }
        }

        /// <summary>
        /// 處理後要儲存到什麼地方，directory : 目錄；db : 資料庫
        /// </summary>
        [JsonProperty("destination")]
        public string Destination
        {
            get { return this.destination; }
            set { this.destination = value; }
        }

        /// <summary>
        /// 處理後的目錄
        /// </summary>
        [JsonProperty("dir")]
        public string Dir
        {
            get { return this.dir; }
            set { this.dir = value; }
        }

        /// <summary>
        /// 設定資料庫連接字串
        /// </summary>
        [JsonProperty("connectionString")]
        public string ConnectionString
        {
            get { return this.connectionString; }
            set { this.connectionString = value; }
        }
    }

    /// <summary>
    /// 檔案處理方式的 json 陣列
    /// </summary>
    public class Configs
    {
        /// <summary>
        /// 檔案處理方式的 json 陣列屬性
        /// </summary>
        [JsonProperty("configs")]
        public List<Config> configs { get; set; }

        /// <summary>
        /// 建構子
        /// </summary>
        public Configs()
        {
            configs = new List<Config>();
        }
    }
}