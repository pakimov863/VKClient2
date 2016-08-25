using System;
using VKLib.Model.Attachments;
using VKLib.Utils;

namespace VKLib.Model
{
	/// <summary>
	/// ������� �������
	/// </summary>
	[Serializable]
	public class MarketAlbum : MediaAttachment
	{
		static MarketAlbum()
		{
			RegisterType(typeof(MarketAlbum), "market_album");
		}
		/// <summary>
		/// �������� ��������. ������
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// ������� ��������, ������ photo.
		/// </summary>
		public Photo Photo { get; set; }

		/// <summary>
		/// ����� ������� � ��������; int (�������� ��������)
		/// </summary>
		public int Count { get; set; }

		/// <summary>
		/// ���� ���������� �������� � ������� unixtime. ������������� �����
		/// </summary>
		public DateTime? UpdatedTime { get; set; }

		/// <summary>
		/// ��������� �� json.
		/// </summary>
		/// <param name="response">����� �������.</param>
		/// <returns></returns>
		internal static MarketAlbum FromJson(VkResponse response)
		{
			var application = new MarketAlbum
			{
				Id = response["id"],
				OwnerId = response["owner_id"],
				Title = response["title"],
				Photo = response["photo"],
				Count = response["count"],
				UpdatedTime = response["updated_time"]
			};

			return application;
		}
	}
}