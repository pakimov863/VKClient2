﻿using System;

namespace VKLib.Enums
{
	/// <summary>
	/// Информация о том прочитано ли сообщение.
	/// </summary>
	[Serializable]
	public enum MessageReadState
    {
        /// <summary>
        /// Сообщение не прочитано.
        /// </summary>
        Unreaded = 0,

        /// <summary>
        /// Сообщение прочитано.
        /// </summary>
        Readed = 1
    }
}