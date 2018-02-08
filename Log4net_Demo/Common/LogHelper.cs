using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;
using System.IO;
using System.Diagnostics;


namespace Log4net_Demo.Common
{
    public class LogHelper
    {
        public static ILog log;
        //static string log4netConfig = $@"{ AppDomain.CurrentDomain.BaseDirectory }\log4net.config";
        static LogHelper()
        {
            //try
            //{
            //    log4net.Config.XmlConfigurator.Configure(new FileInfo(log4netConfig));
            //    log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            //}
            //catch (Exception ex)
            //{
            //    //if error occured ,add log to windows event .
            //    if (!EventLog.SourceExists("My Application"))
            //        EventLog.CreateEventSource("My Application", "System");

            //    EventLog eventLog = new EventLog("System");
            //    eventLog.Source = "My Application";
            //    eventLog.WriteEntry(string.Format("log4net error , message {0}", ex.Message));
            //}
        }


        public static void Info(object message)
        {
            if (log.IsInfoEnabled)
            {
                log.Info(message);
            }
        }

        public static void Info(object message, Exception exception)
        {
            if (log.IsInfoEnabled)
            {
                //add common logs
                log.Info(message, exception);
            }

        }

        public static void Error(object message)
        {
            if (log.IsErrorEnabled)
            {
                //add error logs
                log.Error(message);
            }
        }
        public static void Error(object message, Exception exception)
        {
            if (log.IsErrorEnabled)
            {
                //add error logs
                log.Error(message, exception);
            }
        }

        public static void Warn(object message)
        {
            if (log.IsWarnEnabled)
            {
                //add warning logs
                log.Warn(message);
            }
        }
        public static void Warn(object message, Exception exception)
        {
            if (log.IsWarnEnabled)
            {
                //add warning logs
                log.Warn(message, exception);
            }

        }

        public static void Debug(object message)
        {
            if (log.IsDebugEnabled)
            {
                //add debug logs
                log.Debug(message);
            }
        }


        #region logapp


        public static void Info(string logAppender, object message, string fileName = null)
        {
            GetLogger(logAppender, fileName);
            if (log.IsInfoEnabled)
            {
                log.Info(message);
            }
        }
        static string baseLogDirectory = $"{AppDomain.CurrentDomain.BaseDirectory}\\Log\\{DateTime.Now.ToString("yyyy-MM")}\\FIMService\\";
        private static void GetLogger(string logAppender, string fileName)
        {
            try
            {
                if (!string.IsNullOrEmpty(fileName))//若FileName不为空，则修改写入文件名称
                {
                    var repository = LogManager.GetRepository();
                    var appenders = repository.GetAppenders();
                    var targetApder = appenders.First(p => p.Name == $"{logAppender}FileAppender") as log4net.Appender.RollingFileAppender;
                    if (string.IsNullOrEmpty(baseLogDirectory))
                    {
                        baseLogDirectory = targetApder.File;
                    }
                    targetApder.File = $"{baseLogDirectory}{fileName}";
                    //targetApder.Writer = new System.IO.StreamWriter(targetApder.File, targetApder.AppendToFile, targetApder.Encoding);//只更新Write方法，Log日志无法写入，暂未找到解决方案
                    //激活更改，缺点：会更新Repository
                    targetApder.ActivateOptions();
                }
                log = LogManager.GetLogger(logAppender);//重新获取Logger
            }
            catch (Exception ex)
            {
                if (!EventLog.SourceExists("My Application"))
                    EventLog.CreateEventSource("My Application", "System");

                EventLog eventLog = new EventLog("System");
                eventLog.Source = "My Application";
                eventLog.WriteEntry(string.Format("log4net error , message {0}", ex.Message));
            }

        }

        public static void Info(string logAppender, object message, Exception exception)
        {
            log = LogManager.GetLogger(logAppender);
            if (log.IsInfoEnabled)
            {
                //add common logs
                log.Info(message, exception);
            }

        }

        public static void Error(string logAppender, object message)
        {
            log = LogManager.GetLogger(logAppender);
            if (log.IsErrorEnabled)
            {
                //add error logs
                log.Error(message);
            }
        }
        public static void Error(string logAppender, object message, Exception exception)
        {
            log = LogManager.GetLogger(logAppender);
            if (log.IsErrorEnabled)
            {
                //add error logs
                log.Error(message, exception);
            }
        }

        public static void Warn(string logAppender, object message)
        {
            log = LogManager.GetLogger(logAppender);
            if (log.IsWarnEnabled)
            {
                //add warning logs
                log.Warn(message);
            }
        }
        public static void Warn(string logAppender, object message, Exception exception)
        {
            log = LogManager.GetLogger(logAppender);
            if (log.IsWarnEnabled)
            {
                //add warning logs
                log.Warn(message, exception);
            }

        }

        public static void Debug(string logAppender, object message)
        {
            log = LogManager.GetLogger(logAppender);
            if (log.IsDebugEnabled)
            {
                //add debug logs
                log.Debug(message);
            }

        }
        public static void Debug(string logAppender, object message, Exception exception)
        {
            log = LogManager.GetLogger(logAppender);
            if (log.IsDebugEnabled)
            {
                //add debug logs
                log.Debug(message, exception);
            }

        }
        #endregion

        /// <summary>
        /// 输出日志到Log4Net
        /// </summary>
        /// <param name="t"></param>
        /// <param name="ex"></param>
        #region static void WriteLog(Type t, Exception ex)

        public static void WriteLog(Type t, Exception ex)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(t);
            log.Error("Error", ex);
        }

        #endregion

        /// <summary>
        /// 输出日志到Log4Net
        /// </summary>
        /// <param name="t"></param>
        /// <param name="msg"></param>
        #region static void WriteLog(Type t, string msg)

        public static void WriteLog(Type t, string msg)
        {
            log = log4net.LogManager.GetLogger(t);
            log.Error(msg);
        }

        #endregion
    }
}