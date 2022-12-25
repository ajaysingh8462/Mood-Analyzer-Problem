using System.Runtime.Serialization;

namespace Mood_Analyzer_Problem
{
    public enum MoodAnalysisError
    {
        NULL_OR_EMPTY_MOOD,
        INVALID_MOOD
    }

    public class MoodAnalysisException : Exception
    {
        public MoodAnalysisError ErrorCode { get; }

        public MoodAnalysisException(string message, MoodAnalysisError errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}