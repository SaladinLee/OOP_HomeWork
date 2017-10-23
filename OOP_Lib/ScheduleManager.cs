using Newtonsoft.Json;
using System;

namespace OOP_Lib
{
    /// <summary>
    /// 排程設定處理模組
    /// </summary>
    public class ScheduleManager
    {
        /// <summary>
        /// 初始化 Schedules
        /// </summary>
        private Schedules schedules = new Schedules();

        /// <summary>
        /// 回傳 schedules 的資料筆數
        /// </summary>
        public int Count => this.schedules.schedules.Count;

        /// <summary>
        /// 將 schedule.json 轉換為 schedules
        /// </summary>
        /// <param name="scheduleJson">schedule.json 字串</param>
        /// <returns>true:轉換成功 false:轉換失敗</returns>
        public bool ProcessSchedule(string scheduleJson)
        {
            bool result = false;
            try
            {
                this.schedules = JsonConvert.DeserializeObject<Schedules>(scheduleJson);
                result = true;
            }
            catch (Exception e)
            {
                result = false;
                throw new ArgumentException(e.Message);
            }

            return result;
        }
    }
}