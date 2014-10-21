using System;
using System.Threading;


namespace InfinityThread
{
    class InfinityThread
    {
   
            private Thread m_Thread;
            private volatile bool m_Terminated;
            private ManualResetEvent m_EvSuspend;
            private Object obj;

            public InfinityThread()
            {
                m_Terminated = false;
                m_EvSuspend = new ManualResetEvent(true);
                obj = new Object();

                m_Thread = new Thread(new ThreadStart(MyThread));

            }

            public void Start()
            {
                m_Thread.Start();
            }

            public void Dispose()
            {
                m_Terminated = true;
                Resume();
                m_Thread.Join();
                m_EvSuspend.Close();
            }

            public void Suspend()
            {
                m_EvSuspend.Reset();
            }

            public void Resume()
            {
                m_EvSuspend.Set();
            }

            private void MyThread()
            {

                while (!m_Terminated)
                {
                    /* some code
                     * 
                     */

                    m_EvSuspend.WaitOne();
                }
            }
        }
}
