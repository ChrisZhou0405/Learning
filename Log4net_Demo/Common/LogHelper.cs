using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;

namespace Log4net_Demo.Common
{
    public class LogHelper
    {
        public static ILog log;

        //    public LogHelper();

        //    public static void Debug(object message);
        //    public static void Debug(string logAppender, object message);
        //    public static void Debug(string logAppender, object message, Exception exception);
        //    public static void Error(object message);
        //    public static void Error(string logAppender, object message);
        //    public static void Error(string logAppender, object message, Exception exception);
        //    public static void Info(object message);
        //    public static void Info(object message, Exception exception);
        //    public static void Info(string logAppender, object message, string fileName = null);
        //    public static void Info(string logAppender, object message, Exception exception);
        //    public static void Warn(object message);
        //    public static void Warn(object message, Exception exception);
        //    public static void Warn(string logAppender, object message);
        //    public static void Warn(string logAppender, object message, Exception exception);
        //    public static void WriteLog(Type t, string msg);
        //    public static void WriteLog(Type t, Exception ex);

        public static void Error(string logAppender, object message, Exception exception)
        {
            log = LogManager.GetLogger(logAppender);
            log.Error(message, exception);
        }
    }
}