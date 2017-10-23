using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OOP_Lib
{
    /// <summary>
    /// 檔案處理設定檔管理模組
    /// </summary>
    public class ConfigManager
    {
        /// <summary>
        /// 存放 config.json 的資料
        /// </summary>
        private Configs configs = new Configs();

        /// <summary>
        /// 回傳 configs 的資料筆數
        /// </summary>
        public int Count => this.configs.configs.Count;

        /// <summary>
        /// 將 config.json 轉換為 configs
        /// </summary>
        /// <param name="configJson">config.json 字串</param>
        /// <returns>true:轉換成功 false:轉換失敗</returns>
        public bool ProcessConfig(string configJson)
        {
            bool result = false;
            try
            {
                this.configs = JsonConvert.DeserializeObject<Configs>(configJson);
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