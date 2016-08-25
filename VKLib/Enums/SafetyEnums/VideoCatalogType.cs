﻿using VKLib.Utils;

namespace VKLib.Enums.SafetyEnums
{
	/// <summary>
	/// Возможные значения параметра VideoCatalogType, задающего внешний вид окна авторизации.
	/// </summary>
	public sealed class VideoCatalogType : SafetyEnum<VideoCatalogType>
	{
		/// <summary>
		/// Видеозаписи сообщества.
		/// </summary>
		[DefaultValue]
		public static readonly VideoCatalogType Channel = RegisterPossibleValue("channel");

		/// <summary>
		/// Подборки видеозаписей.
		/// </summary>
		public static readonly VideoCatalogType Category = RegisterPossibleValue("category");
	}
}