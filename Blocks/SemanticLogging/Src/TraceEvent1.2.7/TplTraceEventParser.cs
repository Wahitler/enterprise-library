using System;
using System.Text;
using System.Diagnostics;
using Diagnostics.Tracing;
using Diagnostics.Tracing.Parsers;

// This code was automatically generated by the TraceParserGen tool, which converts
// an ETW event manifest into strongly typed C# classes.
namespace Diagnostics.Tracing.Parsers
{

    public sealed class TplEtwProviderTraceEventParser : TraceEventParser 
    {
        public static string ProviderName = "TplEtwProvider";
        public static Guid ProviderGuid = new Guid(unchecked((int) 0x2e5dba47), unchecked((short) 0xa3d2), unchecked((short) 0x4d16), 0x8e, 0xe0, 0x66, 0x71, 0xff, 0xdc, 0xd7, 0xb5);
        public TplEtwProviderTraceEventParser(TraceEventSource source) : base(source) {}

        public event Action<ParallelLoopBeginArgsTraceData> ParallelLoopBegin
        {
            add
            {
                                                         // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
                source.RegisterEventTemplate(new ParallelLoopBeginArgsTraceData(value, 1, 0, null, new Guid(), 11, "ParallelLoopBegin", ProviderGuid, ProviderName));
            }
            remove
            {
                throw new Exception("Not supported");
            }
        }
        public event Action<ParallelLoopEndArgsTraceData> ParallelLoopEnd
        {
            add
            {
                                                         // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
                source.RegisterEventTemplate(new ParallelLoopEndArgsTraceData(value, 2, 0, null, new Guid(), 12, "ParallelLoopEnd", ProviderGuid, ProviderName));
            }
            remove
            {
                throw new Exception("Not supported");
            }
        }
        public event Action<ParallelInvokeBeginArgsTraceData> ParallelInvokeBegin
        {
            add
            {
                                                         // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
                source.RegisterEventTemplate(new ParallelInvokeBeginArgsTraceData(value, 3, 0, null, new Guid(), 13, "ParallelInvokeBegin", ProviderGuid, ProviderName));
            }
            remove
            {
                throw new Exception("Not supported");
            }
        }
        public event Action<ParallelInvokeEndArgsTraceData> ParallelInvokeEnd
        {
            add
            {
                                                         // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
                source.RegisterEventTemplate(new ParallelInvokeEndArgsTraceData(value, 4, 0, null, new Guid(), 14, "ParallelInvokeEnd", ProviderGuid, ProviderName));
            }
            remove
            {
                throw new Exception("Not supported");
            }
        }
        public event Action<ParallelForkArgsTraceData> ParallelFork
        {
            add
            {
                                                         // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
                source.RegisterEventTemplate(new ParallelForkArgsTraceData(value, 5, 0, null, new Guid(), 15, "ParallelFork", ProviderGuid, ProviderName));
            }
            remove
            {
                throw new Exception("Not supported");
            }
        }
        public event Action<ParallelJoinArgsTraceData> ParallelJoin
        {
            add
            {
                                                         // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
                source.RegisterEventTemplate(new ParallelJoinArgsTraceData(value, 6, 0, null, new Guid(), 16, "ParallelJoin", ProviderGuid, ProviderName));
            }
            remove
            {
                throw new Exception("Not supported");
            }
        }
        public event Action<TaskScheduledArgsTraceData> TaskScheduled
        {
            add
            {
                                                         // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
                source.RegisterEventTemplate(new TaskScheduledArgsTraceData(value, 7, 0, null, new Guid(), 17, "TaskScheduled", ProviderGuid, ProviderName));
            }
            remove
            {
                throw new Exception("Not supported");
            }
        }
        public event Action<TaskStartedArgsTraceData> TaskStarted
        {
            add
            {
                                                         // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
                source.RegisterEventTemplate(new TaskStartedArgsTraceData(value, 8, 0, null, new Guid(), 18, "TaskStarted", ProviderGuid, ProviderName));
            }
            remove
            {
                throw new Exception("Not supported");
            }
        }
        public event Action<TaskCompletedArgsTraceData> TaskCompleted
        {
            add
            {
                                                         // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
                source.RegisterEventTemplate(new TaskCompletedArgsTraceData(value, 9, 0, null, new Guid(), 19, "TaskCompleted", ProviderGuid, ProviderName));
            }
            remove
            {
                throw new Exception("Not supported");
            }
        }
        public event Action<TaskWaitBeginArgsTraceData> TaskWaitBegin
        {
            add
            {
                                                         // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
                source.RegisterEventTemplate(new TaskWaitBeginArgsTraceData(value, 10, 0, null, new Guid(), 20, "TaskWaitBegin", ProviderGuid, ProviderName));
            }
            remove
            {
                throw new Exception("Not supported");
            }
        }
        public event Action<TaskWaitEndArgsTraceData> TaskWaitEnd
        {
            add
            {
                                                         // action, eventid, taskid, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName
                source.RegisterEventTemplate(new TaskWaitEndArgsTraceData(value, 11, 0, null, new Guid(), 21, "TaskWaitEnd", ProviderGuid, ProviderName));
            }
            remove
            {
                throw new Exception("Not supported");
            }
        }

       #region Event ID Definitions
        public const TraceEventID ParallelLoopBeginEventID = (TraceEventID) 1;
        public const TraceEventID ParallelLoopEndEventID = (TraceEventID) 2;
        public const TraceEventID ParallelInvokeBeginEventID = (TraceEventID) 3;
        public const TraceEventID ParallelInvokeEndEventID = (TraceEventID) 4;
        public const TraceEventID ParallelForkEventID = (TraceEventID) 5;
        public const TraceEventID ParallelJoinEventID = (TraceEventID) 6;
        public const TraceEventID TaskScheduledEventID = (TraceEventID) 7;
        public const TraceEventID TaskStartedEventID = (TraceEventID) 8;
        public const TraceEventID TaskCompletedEventID = (TraceEventID) 9;
        public const TraceEventID TaskWaitBeginEventID = (TraceEventID) 10;
        public const TraceEventID TaskWaitEndEventID = (TraceEventID) 11;
       #endregion

    #region private
    #endregion
    }

    public sealed class ParallelLoopBeginArgsTraceData : TraceEvent
    {
        public int OriginatingTaskSchedulerID { get { return GetInt32At(0); } }
        public int OriginatingTaskID { get { return GetInt32At(4); } }
        public int ForkJoinContextID { get { return GetInt32At(8); } }
        public int OperationType { get { return GetInt32At(12); } }
        public long InclusiveFrom { get { return GetInt64At(16); } }
        public long ExclusiveTo { get { return GetInt64At(24); } }

        #region Private
        internal ParallelLoopBeginArgsTraceData(Action<ParallelLoopBeginArgsTraceData> action, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.Action = action;
        }
         protected internal override void Dispatch()
        {
            Action(this);
        }
         protected internal override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != 32));
            Debug.Assert(!(Version > 0 && EventDataLength < 32));
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
             Prefix(sb);
             sb.XmlAttrib("OriginatingTaskSchedulerID", OriginatingTaskSchedulerID);
             sb.XmlAttrib("OriginatingTaskID", OriginatingTaskID);
             sb.XmlAttrib("ForkJoinContextID", ForkJoinContextID);
             sb.XmlAttrib("OperationType", OperationType);
             sb.XmlAttrib("InclusiveFrom", InclusiveFrom);
             sb.XmlAttrib("ExclusiveTo", ExclusiveTo);
             sb.Append("/>");
             return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "OriginatingTaskSchedulerID", "OriginatingTaskID", "ForkJoinContextID", "OperationType", "InclusiveFrom", "ExclusiveTo"};
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return OriginatingTaskSchedulerID;
                case 1:
                    return OriginatingTaskID;
                case 2:
                    return ForkJoinContextID;
                case 3:
                    return OperationType;
                case 4:
                    return InclusiveFrom;
                case 5:
                    return ExclusiveTo;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<ParallelLoopBeginArgsTraceData> Action;
        #endregion
    }
    public sealed class ParallelLoopEndArgsTraceData : TraceEvent
    {
        public int OriginatingTaskSchedulerID { get { return GetInt32At(0); } }
        public int OriginatingTaskID { get { return GetInt32At(4); } }
        public int ForkJoinContextID { get { return GetInt32At(8); } }
        public long TotalIterations { get { return GetInt64At(12); } }

        #region Private
        internal ParallelLoopEndArgsTraceData(Action<ParallelLoopEndArgsTraceData> action, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.Action = action;
        }
         protected internal override void Dispatch()
        {
            Action(this);
        }
         protected internal override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != 20));
            Debug.Assert(!(Version > 0 && EventDataLength < 20));
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
             Prefix(sb);
             sb.XmlAttrib("OriginatingTaskSchedulerID", OriginatingTaskSchedulerID);
             sb.XmlAttrib("OriginatingTaskID", OriginatingTaskID);
             sb.XmlAttrib("ForkJoinContextID", ForkJoinContextID);
             sb.XmlAttrib("TotalIterations", TotalIterations);
             sb.Append("/>");
             return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "OriginatingTaskSchedulerID", "OriginatingTaskID", "ForkJoinContextID", "TotalIterations"};
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return OriginatingTaskSchedulerID;
                case 1:
                    return OriginatingTaskID;
                case 2:
                    return ForkJoinContextID;
                case 3:
                    return TotalIterations;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<ParallelLoopEndArgsTraceData> Action;
        #endregion
    }
    public sealed class ParallelInvokeBeginArgsTraceData : TraceEvent
    {
        public int OriginatingTaskSchedulerID { get { return GetInt32At(0); } }
        public int OriginatingTaskID { get { return GetInt32At(4); } }
        public int ForkJoinContextID { get { return GetInt32At(8); } }
        public int OperationType { get { return GetInt32At(12); } }
        public int ActionCount { get { return GetInt32At(16); } }

        #region Private
        internal ParallelInvokeBeginArgsTraceData(Action<ParallelInvokeBeginArgsTraceData> action, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.Action = action;
        }
         protected internal override void Dispatch()
        {
            Action(this);
        }
         protected internal override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != 20));
            Debug.Assert(!(Version > 0 && EventDataLength < 20));
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
             Prefix(sb);
             sb.XmlAttrib("OriginatingTaskSchedulerID", OriginatingTaskSchedulerID);
             sb.XmlAttrib("OriginatingTaskID", OriginatingTaskID);
             sb.XmlAttrib("ForkJoinContextID", ForkJoinContextID);
             sb.XmlAttrib("OperationType", OperationType);
             sb.XmlAttrib("ActionCount", ActionCount);
             sb.Append("/>");
             return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "OriginatingTaskSchedulerID", "OriginatingTaskID", "ForkJoinContextID", "OperationType", "ActionCount"};
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return OriginatingTaskSchedulerID;
                case 1:
                    return OriginatingTaskID;
                case 2:
                    return ForkJoinContextID;
                case 3:
                    return OperationType;
                case 4:
                    return ActionCount;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<ParallelInvokeBeginArgsTraceData> Action;
        #endregion
    }
    public sealed class ParallelInvokeEndArgsTraceData : TraceEvent
    {
        public int OriginatingTaskSchedulerID { get { return GetInt32At(0); } }
        public int OriginatingTaskID { get { return GetInt32At(4); } }
        public int ForkJoinContextID { get { return GetInt32At(8); } }

        #region Private
        internal ParallelInvokeEndArgsTraceData(Action<ParallelInvokeEndArgsTraceData> action, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.Action = action;
        }
         protected internal override void Dispatch()
        {
            Action(this);
        }
         protected internal override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != 12));
            Debug.Assert(!(Version > 0 && EventDataLength < 12));
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
             Prefix(sb);
             sb.XmlAttrib("OriginatingTaskSchedulerID", OriginatingTaskSchedulerID);
             sb.XmlAttrib("OriginatingTaskID", OriginatingTaskID);
             sb.XmlAttrib("ForkJoinContextID", ForkJoinContextID);
             sb.Append("/>");
             return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "OriginatingTaskSchedulerID", "OriginatingTaskID", "ForkJoinContextID"};
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return OriginatingTaskSchedulerID;
                case 1:
                    return OriginatingTaskID;
                case 2:
                    return ForkJoinContextID;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<ParallelInvokeEndArgsTraceData> Action;
        #endregion
    }
    public sealed class ParallelForkArgsTraceData : TraceEvent
    {
        public int OriginatingTaskManager { get { return GetInt32At(0); } }
        public int OriginatingTaskID { get { return GetInt32At(4); } }
        public int ForkJoinContextID { get { return GetInt32At(8); } }

        #region Private
        internal ParallelForkArgsTraceData(Action<ParallelForkArgsTraceData> action, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.Action = action;
        }
         protected internal override void Dispatch()
        {
            Action(this);
        }
         protected internal override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != 12));
            Debug.Assert(!(Version > 0 && EventDataLength < 12));
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
             Prefix(sb);
             sb.XmlAttrib("OriginatingTaskManager", OriginatingTaskManager);
             sb.XmlAttrib("OriginatingTaskID", OriginatingTaskID);
             sb.XmlAttrib("ForkJoinContextID", ForkJoinContextID);
             sb.Append("/>");
             return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "OriginatingTaskManager", "OriginatingTaskID", "ForkJoinContextID"};
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return OriginatingTaskManager;
                case 1:
                    return OriginatingTaskID;
                case 2:
                    return ForkJoinContextID;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<ParallelForkArgsTraceData> Action;
        #endregion
    }
    public sealed class ParallelJoinArgsTraceData : TraceEvent
    {
        public int OriginatingTaskSchedulerID { get { return GetInt32At(0); } }
        public int OriginatingTaskID { get { return GetInt32At(4); } }
        public int ForkJoinContextID { get { return GetInt32At(8); } }

        #region Private
        internal ParallelJoinArgsTraceData(Action<ParallelJoinArgsTraceData> action, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.Action = action;
        }
         protected internal override void Dispatch()
        {
            Action(this);
        }
         protected internal override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != 12));
            Debug.Assert(!(Version > 0 && EventDataLength < 12));
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
             Prefix(sb);
             sb.XmlAttrib("OriginatingTaskSchedulerID", OriginatingTaskSchedulerID);
             sb.XmlAttrib("OriginatingTaskID", OriginatingTaskID);
             sb.XmlAttrib("ForkJoinContextID", ForkJoinContextID);
             sb.Append("/>");
             return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "OriginatingTaskSchedulerID", "OriginatingTaskID", "ForkJoinContextID"};
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return OriginatingTaskSchedulerID;
                case 1:
                    return OriginatingTaskID;
                case 2:
                    return ForkJoinContextID;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<ParallelJoinArgsTraceData> Action;
        #endregion
    }
    public sealed class TaskScheduledArgsTraceData : TraceEvent
    {
        public int OriginatingTaskSchedulerID { get { return GetInt32At(0); } }
        public int OriginatingTaskID { get { return GetInt32At(4); } }
        public int TaskID { get { return GetInt32At(8); } }
        public int CreatingTaskID { get { return GetInt32At(12); } }
        public int TaskCreationOptions { get { return GetInt32At(16); } }

        #region Private
        internal TaskScheduledArgsTraceData(Action<TaskScheduledArgsTraceData> action, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.Action = action;
        }
         protected internal override void Dispatch()
        {
            Action(this);
        }
         protected internal override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != 20));
            Debug.Assert(!(Version > 0 && EventDataLength < 20));
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
             Prefix(sb);
             sb.XmlAttrib("OriginatingTaskSchedulerID", OriginatingTaskSchedulerID);
             sb.XmlAttrib("OriginatingTaskID", OriginatingTaskID);
             sb.XmlAttrib("TaskID", TaskID);
             sb.XmlAttrib("CreatingTaskID", CreatingTaskID);
             sb.XmlAttrib("TaskCreationOptions", TaskCreationOptions);
             sb.Append("/>");
             return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "OriginatingTaskSchedulerID", "OriginatingTaskID", "TaskID", "CreatingTaskID", "TaskCreationOptions"};
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return OriginatingTaskSchedulerID;
                case 1:
                    return OriginatingTaskID;
                case 2:
                    return TaskID;
                case 3:
                    return CreatingTaskID;
                case 4:
                    return TaskCreationOptions;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<TaskScheduledArgsTraceData> Action;
        #endregion
    }
    public sealed class TaskStartedArgsTraceData : TraceEvent
    {
        public int OriginatingTaskSchedulerID { get { return GetInt32At(0); } }
        public int OriginatingTaskID { get { return GetInt32At(4); } }
        public int TaskID { get { return GetInt32At(8); } }

        #region Private
        internal TaskStartedArgsTraceData(Action<TaskStartedArgsTraceData> action, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.Action = action;
        }
         protected internal override void Dispatch()
        {
            Action(this);
        }
         protected internal override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != 12));
            Debug.Assert(!(Version > 0 && EventDataLength < 12));
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
             Prefix(sb);
             sb.XmlAttrib("OriginatingTaskSchedulerID", OriginatingTaskSchedulerID);
             sb.XmlAttrib("OriginatingTaskID", OriginatingTaskID);
             sb.XmlAttrib("TaskID", TaskID);
             sb.Append("/>");
             return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "OriginatingTaskSchedulerID", "OriginatingTaskID", "TaskID"};
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return OriginatingTaskSchedulerID;
                case 1:
                    return OriginatingTaskID;
                case 2:
                    return TaskID;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<TaskStartedArgsTraceData> Action;
        #endregion
    }
    public sealed class TaskCompletedArgsTraceData : TraceEvent
    {
        public int OriginatingTaskSchedulerID { get { return GetInt32At(0); } }
        public int OriginatingTaskID { get { return GetInt32At(4); } }
        public int TaskID { get { return GetInt32At(8); } }
        public bool IsExceptional { get { return GetByteAt(12) != 0; } }

        #region Private
        internal TaskCompletedArgsTraceData(Action<TaskCompletedArgsTraceData> action, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.Action = action;
        }
         protected internal override void Dispatch()
        {
            Action(this);
        }
         protected internal override void Validate()
        {
            // In V4.0 bools were serialized as 1 byte, but in V4.5 it was changed to be 4 bytes.   
            // Make the code robust to either case.   (Note I changed IsExceptional to only look at one byte).  
            Debug.Assert(!(Version == 0 && EventDataLength != 13 && EventDataLength != 16));
            Debug.Assert(!(Version > 0 && EventDataLength < 16));
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
             Prefix(sb);
             sb.XmlAttrib("OriginatingTaskSchedulerID", OriginatingTaskSchedulerID);
             sb.XmlAttrib("OriginatingTaskID", OriginatingTaskID);
             sb.XmlAttrib("TaskID", TaskID);
             sb.XmlAttrib("IsExceptional", IsExceptional);
             sb.Append("/>");
             return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "OriginatingTaskSchedulerID", "OriginatingTaskID", "TaskID", "IsExceptional"};
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return OriginatingTaskSchedulerID;
                case 1:
                    return OriginatingTaskID;
                case 2:
                    return TaskID;
                case 3:
                    return IsExceptional;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<TaskCompletedArgsTraceData> Action;
        #endregion
    }
    public sealed class TaskWaitBeginArgsTraceData : TraceEvent
    {
        public int OriginatingTaskSchedulerID { get { return GetInt32At(0); } }
        public int OriginatingTaskID { get { return GetInt32At(4); } }
        public int TaskID { get { return GetInt32At(8); } }

        #region Private
        internal TaskWaitBeginArgsTraceData(Action<TaskWaitBeginArgsTraceData> action, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.Action = action;
        }
         protected internal override void Dispatch()
        {
            Action(this);
        }
         protected internal override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != 12));
            Debug.Assert(!(Version > 0 && EventDataLength < 12));
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
             Prefix(sb);
             sb.XmlAttrib("OriginatingTaskSchedulerID", OriginatingTaskSchedulerID);
             sb.XmlAttrib("OriginatingTaskID", OriginatingTaskID);
             sb.XmlAttrib("TaskID", TaskID);
             sb.Append("/>");
             return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "OriginatingTaskSchedulerID", "OriginatingTaskID", "TaskID"};
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return OriginatingTaskSchedulerID;
                case 1:
                    return OriginatingTaskID;
                case 2:
                    return TaskID;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<TaskWaitBeginArgsTraceData> Action;
        #endregion
    }
    public sealed class TaskWaitEndArgsTraceData : TraceEvent
    {
        public int OriginatingTaskSchedulerID { get { return GetInt32At(0); } }
        public int OriginatingTaskID { get { return GetInt32At(4); } }
        public int TaskID { get { return GetInt32At(8); } }

        #region Private
        internal TaskWaitEndArgsTraceData(Action<TaskWaitEndArgsTraceData> action, int eventID, int task, string taskName, Guid taskGuid, int opcode, string opcodeName, Guid providerGuid, string providerName)
            : base(eventID, task, taskName, taskGuid, opcode, opcodeName, providerGuid, providerName)
        {
            this.Action = action;
        }
         protected internal override void Dispatch()
        {
            Action(this);
        }
         protected internal override void Validate()
        {
            Debug.Assert(!(Version == 0 && EventDataLength != 12));
            Debug.Assert(!(Version > 0 && EventDataLength < 12));
        }
        public override StringBuilder ToXml(StringBuilder sb)
        {
             Prefix(sb);
             sb.XmlAttrib("OriginatingTaskSchedulerID", OriginatingTaskSchedulerID);
             sb.XmlAttrib("OriginatingTaskID", OriginatingTaskID);
             sb.XmlAttrib("TaskID", TaskID);
             sb.Append("/>");
             return sb;
        }

        public override string[] PayloadNames
        {
            get
            {
                if (payloadNames == null)
                    payloadNames = new string[] { "OriginatingTaskSchedulerID", "OriginatingTaskID", "TaskID"};
                return payloadNames;
            }
        }

        public override object PayloadValue(int index)
        {
            switch (index)
            {
                case 0:
                    return OriginatingTaskSchedulerID;
                case 1:
                    return OriginatingTaskID;
                case 2:
                    return TaskID;
                default:
                    Debug.Assert(false, "Bad field index");
                    return null;
            }
        }

        private event Action<TaskWaitEndArgsTraceData> Action;
        #endregion
    }

}