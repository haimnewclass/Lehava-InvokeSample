using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvokeSample
{
    class RandomJob
    {
        public System.Windows.Forms.Label sendToLabel = null;
        public RandomJob()
        {
            RunForRandomNumbers();
        }

        public string num;
        Random r = new Random();
        public string GetNum()
        {            
            return r.Next(1, 1000).ToString();
        }

        public void UpdateLabel()
        {

        }
        public Task RunForRandomNumbers()
        {
            return Task.Factory.StartNew(() => {

            while (true)
            {
                num = GetNum();
                System.Threading.Thread.Sleep(1000);
                // label
                if (sendToLabel != null)
                {
                    //sendToLabel.Text = num;
                    if (sendToLabel.InvokeRequired)
                    {
                            // invoke
                            sendToLabel.Invoke(new Action(() => { sendToLabel.Text = num; }));
                        }
                        else
                        {
                            sendToLabel.Text = num;
                        }

                    }
                }
            });
        }
    }
}
