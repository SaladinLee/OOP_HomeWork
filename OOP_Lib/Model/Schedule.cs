using Newtonsoft.Json;
using System.Collections.Generic;

namespace OOP_Lib
{
    /// <summary>
    /// 檔案類型的處理排程
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// 副檔名類型
        /// </summary>
        private string Ext;

        /// <summary>
        /// 排程啟動時間
        /// </summary>
        private string Time;

        /// <summary>
        /// 排程啟動週期
        /// </summary>
        private string Interval;

        /// <summary>
        /// 建構子
        /// </summary>
        public Schedule()
        {
            this.Ext = string.Empty;
            this.Time = string.Empty;
            this.Interval = string.Empty;
        }

        /// <summary>
        /// 副檔名類型
        /// </summary>
        [JsonProperty("ext")]
        public string ext
        {
            get { return this.Ext; }
            set { this.Ext = value; }
        }

        /// <summary>
        /// 排程啟動時間
        /// </summary>
        [JsonProperty("time")]
        public string time
        {
            get { return this.Time; }
            set { this.Time = value; }
        }

        /// <summary>
        /// 排程啟動週期
        /// </summary>
        [JsonProperty("interval")]
        public string interval
        {
            get { return this.Interval; }
            set { this.Interval = value; }
        }
    }

    /// <summary>
    /// 排程設定的 json 陣列
    /// </summary>
    public class Schedules
    {
        /// <summary>
        /// 排程設定的 json 陣列屬性
        /// </summary>
        [JsonProperty("schedules")]
        public List<Schedule> schedules { get; set; }

        /// <summary>
        /// 建構子
        /// </summary>
        public Schedules()
        {
            schedules = new List<Schedule>();
        }
    }
}