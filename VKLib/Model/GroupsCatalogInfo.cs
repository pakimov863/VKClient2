﻿using System.Collections.Generic;
using VKLib.Utils;

namespace VKLib.Model
{
	/// <summary>
	/// Ответ на запрос метода groups.getCatalogInfo
	/// </summary>
	public class GroupsCatalogInfo
	{
		/// <summary>
		/// Признак доступности каталога для пользователя.
		/// </summary>
		public bool Enabled { get; set; }

		/// <summary>
		/// Список категорий.
		/// </summary>
		public IEnumerable<CategoryGroup> Categories;

		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response">Ответ сервера.</param>
		/// <returns></returns>
		internal static GroupsCatalogInfo FromJson(VkResponse response)
		{
			var result = new GroupsCatalogInfo
			{
				Enabled = response["enabled"],
				Categories = response["categories"].ToReadOnlyCollectionOf<CategoryGroup>(o => o)
			};

			return result;
		}
	}
}