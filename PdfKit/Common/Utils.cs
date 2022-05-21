using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace PdfKit
{
    public partial class Utils
    {
        public static void ClearEventHandler(Component obj, string eventName)
        {
            Type t = obj.GetType();
            EventHandlerList eventHandlerList = (EventHandlerList)t.InvokeMember("Events", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.GetProperty, null, obj, null);
            object key = t.InvokeMember(eventName, BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.GetField, null, null, null);
            Delegate eventDelegate = eventHandlerList[key];
            if (eventDelegate != null)
            {
                foreach (Delegate invocation in eventDelegate.GetInvocationList())
                {
                    eventHandlerList.RemoveHandler(key, invocation);
                }
            }
        }

        public static object InvokeStaticMember(Type type, string methodName)
        {
            return InvokeStaticMember(type, methodName, null);
        }

        public static object InvokeStaticMember(Type type, string methodName, object[] param)
        {
            return type.InvokeMember(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.InvokeMethod, null, null, param);
        }

        public static object InvokeMember(BindingFlags flag, object obj, string methodName, object[] value)
        {
            return obj.GetType().InvokeMember(methodName, BindingFlags.Public | BindingFlags.Instance | flag, null, obj, value);
        }

        /// <summary>
        /// 跨线程设置控件属性值委托类型定义
        /// </summary>
        private delegate object InvokeMemberCallBack(BindingFlags flag, object obj, string methodName, object[] value);
        public static object InvokeMember(BindingFlags flag, Control control, string name, object[] value)
        {
            if (control.InvokeRequired == true)
                return control.Invoke(new InvokeMemberCallBack(InvokeMember), new object[] { flag, control, name, value });
            else
                return InvokeMember(flag, (object)control, name, value);
        }

        /// <summary>
        /// 跨线程设置控件属性值
        /// </summary>
        public static void PropertySet(Control control, string name, object value)
        {
            InvokeMember(BindingFlags.SetProperty, control, name, new object[] { value });
        }

        /// 跨线程读取控件属性值
        /// </summary>
        public static object PropertyGet(Control control, string name)
        {
            return InvokeMember(BindingFlags.GetProperty, control, name, null);
        }

        public delegate void SimpleCallBack();
        public static void Invoke(Control control, SimpleCallBack func)
        {
            if (control.InvokeRequired)
                control.Invoke(new SimpleCallBack(func));
            else
                func();
        }

        public static void RunBackgroundWorker(BackgroundWorker backgroundWorker, DoWorkEventHandler doWork, RunWorkerCompletedEventHandler runComplete)
        {
            ClearEventHandler(backgroundWorker, "doWorkKey");
            ClearEventHandler(backgroundWorker, "runWorkerCompletedKey");
            backgroundWorker.WorkerReportsProgress = false;
            backgroundWorker.DoWork += doWork;
            backgroundWorker.RunWorkerCompleted += runComplete;
            backgroundWorker.RunWorkerAsync();
        }

        public static void RunBackgroundWorker(BackgroundWorker backgroundWorker, DoWorkEventHandler doWork, ProgressChangedEventHandler reportProgress, RunWorkerCompletedEventHandler runComplete)
        {
            ClearEventHandler(backgroundWorker, "doWorkKey");
            ClearEventHandler(backgroundWorker, "progressChangedKey");
            ClearEventHandler(backgroundWorker, "runWorkerCompletedKey");
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += doWork;
            backgroundWorker.ProgressChanged += reportProgress;
            backgroundWorker.RunWorkerCompleted += runComplete;
            backgroundWorker.RunWorkerAsync();
        }

        public static void CallMethod(Assembly assembly, Type type, Action<Type> func)
        {
            foreach (Type _type in assembly.GetTypes())
            {
                if (type.IsAssignableFrom(_type))
                {
                    if (func != null)
                        func(_type);
                }
            }
        }
    }
}
