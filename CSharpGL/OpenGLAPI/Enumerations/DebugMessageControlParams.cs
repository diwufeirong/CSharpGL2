﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    public enum DebugMessageControlSource : uint
    {
        DONT_CARE = GL.GL_DONT_CARE,
        API_ARB = GL.GL_DEBUG_SOURCE_API_ARB,
        WINDOW_SYSTEM_ARB = GL.GL_DEBUG_SOURCE_WINDOW_SYSTEM_ARB,
        SHADER_COMPILER_ARB = GL.GL_DEBUG_SOURCE_SHADER_COMPILER_ARB,
        THIRD_PARTY_ARB = GL.GL_DEBUG_SOURCE_THIRD_PARTY_ARB,
        APPLICATION_ARB = GL.GL_DEBUG_SOURCE_APPLICATION_ARB,
        OTHER_ARB = GL.GL_DEBUG_SOURCE_OTHER_ARB,
    }

    public enum DebugMessageControlType : uint
    {
        DONT_CARE = GL.GL_DONT_CARE,
        DEBUG_TYPE_ERROR_ARB = GL.GL_DEBUG_TYPE_ERROR_ARB,
        DEBUG_TYPE_DEPRECATED_BEHAVIOR_ARB = GL.GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_ARB,
        DEBUG_TYPE_UNDEFINED_BEHAVIOR_ARB = GL.GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_ARB,
        DEBUG_TYPE_PORTABILITY_ARB = GL.GL_DEBUG_TYPE_PORTABILITY_ARB,
        DEBUG_TYPE_PERFORMANCE_ARB = GL.GL_DEBUG_TYPE_PERFORMANCE_ARB,
        DEBUG_TYPE_OTHER_ARB = GL.GL_DEBUG_TYPE_OTHER_ARB,
    }

    public enum DebugMessageControlSeverity : uint
    {
        DONT_CARE = GL.GL_DONT_CARE,
        DEBUG_SEVERITY_HIGH_ARB = GL.GL_DEBUG_SEVERITY_HIGH_ARB,
        DEBUG_SEVERITY_MEDIUM_ARB = GL.GL_DEBUG_SEVERITY_MEDIUM_ARB,
        DEBUG_SEVERITY_LOW_ARB = GL.GL_DEBUG_SEVERITY_LOW_ARB,
        //DEBUG_SEVERITY_NOTIFICATION_ARB = GL.GL_DEBUG_SEVERITY_NOTIFICATION_ARB,
    }
}
