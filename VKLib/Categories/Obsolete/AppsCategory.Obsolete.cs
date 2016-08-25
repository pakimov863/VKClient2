﻿using System;
using System.Collections.ObjectModel;
using VKLib.Enums.Filters;
using VKLib.Enums.SafetyEnums;
using VKLib.Model;
using VKLib.Model.RequestParams;
using VKLib.Utils;

namespace VKLib.Categories
{
	public partial class AppsCategory
	{
		/// <summary>
		/// Возвращает список приложений, доступных для пользователей сайта через каталог приложений.
		/// </summary>
		/// <param name="totalCount">Количество приложений.</param>
		/// <param name="params">Параметры запроса.</param>
		/// <returns>
		/// После успешного выполнения возвращает общее число найденных приложений и массив объектов приложений.
		/// </returns>
		/// <remarks>
		/// К методу можно делать не более 60 запросов в минуту с одного IP или id.
		/// Страница документации ВКонтакте <seealso cref="http://vk.com/dev/apps.getCatalog" />.
		/// </remarks>
		[ApiVersion("5.44")]
		[Obsolete("Данный метод устарел. Используйте GetCatalog(AppGetCatalogParams @params)")]
		public ReadOnlyCollection<App> GetCatalog(out long totalCount, AppGetCatalogParams @params)
		{
			var response = GetCatalog(@params);

			totalCount = Convert.ToInt64(response.TotalCount);

			return response.ToReadOnlyCollection();
		}

		/// <summary>
		/// Возвращает данные о запрошенном приложении на платформе ВКонтакте
		/// </summary>
		/// <param name="totalCount">Количество приложений.</param>
		/// <param name="params">Параметры запроса.</param>
		/// <returns>
		/// После успешного выполнения возвращает объект приложения.
		/// </returns>
		/// <remarks>
		/// Страница документации ВКонтакте <see href="http://vk.com/dev/apps.get" />.
		/// </remarks>
		[ApiVersion("5.44")]
		[Obsolete("Данный метод устарел. Используйте Get(AppGetParams @params)")]
		public ReadOnlyCollection<App> Get(out long totalCount, AppGetParams @params)
		{
			var response = Get(@params);

			totalCount = Convert.ToInt64(response.TotalCount);

			return response.ToReadOnlyCollection();
		}

		/// <summary>
		/// Создает список друзей, который будет использоваться при отправке пользователем приглашений в приложение.
		/// </summary>
		/// <param name="totalCount">Количество приложений.</param>
		/// <param name="type">Тип создаваемого списка друзей.</param>
		/// <param name="extended">Расширенный.</param>
		/// <param name="count">Количество пользователей в создаваемом списке.</param>
		/// <param name="offset">Смещение относительно первого пользователя для выборки определенного подмножества.</param>
		/// <param name="fields">Список дополнительных полей профилей, которые необходимо вернуть. См. подробное описание.</param>
		/// <returns>
		/// После успешного выполнения возвращает список пользователей.
		/// </returns>
		/// <remarks>
		/// Страница документации ВКонтакте <see href="http://vk.com/dev/apps.getFriendsList" />.
		/// </remarks>
		[ApiVersion("5.44")]
		[Obsolete("Данный метод устарел. Используйте GetFriendsList(AppRequestType type, bool? extended = null, long? count = null, long? offset = null, UsersFields fields = null)")]
		public ReadOnlyCollection<User> GetFriendsList(out long totalCount, AppRequestType type, bool? extended = null, long? count = null, long? offset = null, UsersFields fields = null)
		{
			var result = GetFriendsList(type, extended, count, offset, fields);

			totalCount = Convert.ToInt64(result.TotalCount);

			return result.ToReadOnlyCollection();
		}

	}
}