namespace Project_Domain.Public;

public class Setting
{
	public int SettingId { get; set; }
	public string WebsitePersianTitle { get; set; }
	public string? WebsitePersianDescription { get; set; }
	public string? WebsitePersianKeywords { get; set; }
	public string WebsiteEnglishTitle { get; set; }
	public string? WebsiteEnglishDescription { get; set; }
	public string? WebsiteEnglishKeywords { get; set; }
	public string WebsiteArabicTitle { get; set; }
	public string? WebsiteArabicDescription { get; set; }
	public string? WebsiteArabicKeywords { get; set; }
	public string WebsiteSwedishTitle { get; set; }
	public string? WebsiteSwedishDescription { get; set; }
	public string? WebsiteSwedishKeywords { get; set; }
	public string? ParsGreenApi { get; set; }
	public string? ParsGreenNumber { get; set; }
	public string? ZarrinPalApi { get; set; }
	public string? ApplicationVersion { get; set; }
	public string? GooglePlayStoreUrl { get; set; }
	public string? AppStoreUrl { get; set; }
	public string? BazaarUrl { get; set; }
	public string? MyketUrl { get; set; }
	public string? WebsiteUrl { get; set; }
	public string LogoName { get; set; }
	public string AndroidApplicationFileName { get; set; }
	public bool ApplicationHaveUpdate { get; set; }
}