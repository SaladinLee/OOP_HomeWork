using OOP_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    /// <summary>
    /// OOP 作業畫面
    /// </summary>
    public partial class FrmOOP : Form
    {
        /// <summary>
        /// 建立 ConfigManager
        /// </summary>
        private ConfigManager configManager = new ConfigManager();

        /// <summary>
        /// 建立 ScheduleManager
        /// </summary>
        private ScheduleManager scheduleManager = new ScheduleManager();

        /// <summary>
        /// 建構子
        /// </summary>
        public FrmOOP()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 程式載入時的執行作業
        /// </summary>
        /// <param name="sender">動作</param>
        /// <param name="e">事件</param>
        private void FrmOOP_Load(object sender, EventArgs e)
        {
            if (this.configManager != null && this.configManager.ProcessConfig(configJson.Text))
            {
                this.configsCount.Text = this.configManager.Count.ToString();
            }

            if (this.scheduleManager != null && this.scheduleManager.ProcessSchedule(scheduleJson.Text))
            {
                this.schedulesCount.Text = this.scheduleManager.Count.ToString();
            }
        }
    }
}