﻿using System;
using VKLib.Utils;

namespace VKLib.Model
{
	/// <summary>
	/// Категория товара.
	/// </summary>
	[Serializable]
	public class MarketCategory
	{
		/// <summary>
		/// Идентификатор
		/// </summary>
		public long? Id { get; set; }

		/// <summary>
		/// Название категории
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Секция
		/// </summary>
		public MarketCategorySection Section;

		/// <summary>
		/// Разобрать из json.
		/// </summary>
		/// <param name="response">Ответ сервера.</param>
		/// <returns></returns>
		internal static MarketCategory FromJson(VkResponse response)
		{
			var product = new MarketCategory
			{
				Id = response["id"],
				Name = response["name"],
				Section = response["section"]
			};

			return product;
		}
	}
}