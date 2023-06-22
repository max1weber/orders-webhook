using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace Entities
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class BillingAddress
    {
        [JsonConstructor]
        public BillingAddress(
            [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)] string firstName,
            [JsonProperty("address1", NullValueHandling = NullValueHandling.Ignore)] string address1,
            [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)] string phone,
            [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)] string city,
            [JsonProperty("zip", NullValueHandling = NullValueHandling.Ignore)] string zip,
            [JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)] string province,
            [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)] string country,
            [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)] string lastName,
            [JsonProperty("address2", NullValueHandling = NullValueHandling.Ignore)] object address2,
            [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)] string company,
            [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)] object latitude,
            [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)] object longitude,
            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)] string name,
            [JsonProperty("country_code", NullValueHandling = NullValueHandling.Ignore)] string countryCode,
            [JsonProperty("province_code", NullValueHandling = NullValueHandling.Ignore)] string provinceCode
        )
        {
            this.FirstName = firstName;
            this.Address1 = address1;
            this.Phone = phone;
            this.City = city;
            this.Zip = zip;
            this.Province = province;
            this.Country = country;
            this.LastName = lastName;
            this.Address2 = address2;
            this.Company = company;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Name = name;
            this.CountryCode = countryCode;
            this.ProvinceCode = provinceCode;
        }

        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; }

        [JsonProperty("address1", NullValueHandling = NullValueHandling.Ignore)]
        public string Address1 { get; }

        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; }

        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; }

        [JsonProperty("zip", NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; }

        [JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)]
        public string Province { get; }

        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; }

        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; }

        [JsonProperty("address2", NullValueHandling = NullValueHandling.Ignore)]
        public object Address2 { get; }

        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public string Company { get; }

        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        public object Latitude { get; }

        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        public object Longitude { get; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; }

        [JsonProperty("country_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; }

        [JsonProperty("province_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvinceCode { get; }
    }

    public class CurrentSubtotalPriceSet
    {
        [JsonConstructor]
        public CurrentSubtotalPriceSet(
            [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)] ShopMoney shopMoney,
            [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)] PresentmentMoney presentmentMoney
        )
        {
            this.ShopMoney = shopMoney;
            this.PresentmentMoney = presentmentMoney;
        }

        [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)]
        public ShopMoney ShopMoney { get; }

        [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)]
        public PresentmentMoney PresentmentMoney { get; }
    }

    public class CurrentTotalDiscountsSet
    {
        [JsonConstructor]
        public CurrentTotalDiscountsSet(
            [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)] ShopMoney shopMoney,
            [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)] PresentmentMoney presentmentMoney
        )
        {
            this.ShopMoney = shopMoney;
            this.PresentmentMoney = presentmentMoney;
        }

        [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)]
        public ShopMoney ShopMoney { get; }

        [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)]
        public PresentmentMoney PresentmentMoney { get; }
    }

    public class CurrentTotalPriceSet
    {
        [JsonConstructor]
        public CurrentTotalPriceSet(
            [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)] ShopMoney shopMoney,
            [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)] PresentmentMoney presentmentMoney
        )
        {
            this.ShopMoney = shopMoney;
            this.PresentmentMoney = presentmentMoney;
        }

        [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)]
        public ShopMoney ShopMoney { get; }

        [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)]
        public PresentmentMoney PresentmentMoney { get; }
    }

    public class CurrentTotalTaxSet
    {
        [JsonConstructor]
        public CurrentTotalTaxSet(
            [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)] ShopMoney shopMoney,
            [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)] PresentmentMoney presentmentMoney
        )
        {
            this.ShopMoney = shopMoney;
            this.PresentmentMoney = presentmentMoney;
        }

        [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)]
        public ShopMoney ShopMoney { get; }

        [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)]
        public PresentmentMoney PresentmentMoney { get; }
    }

    public class Customer
    {
        [JsonConstructor]
        public Customer(
            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)] long id,
            [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)] string email,
            [JsonProperty("accepts_marketing", NullValueHandling = NullValueHandling.Ignore)] bool acceptsMarketing,
            [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)] object createdAt,
            [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)] object updatedAt,
            [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)] string firstName,
            [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)] string lastName,
            [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)] string state,
            [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)] object note,
            [JsonProperty("verified_email", NullValueHandling = NullValueHandling.Ignore)] bool verifiedEmail,
            [JsonProperty("multipass_identifier", NullValueHandling = NullValueHandling.Ignore)] object multipassIdentifier,
            [JsonProperty("tax_exempt", NullValueHandling = NullValueHandling.Ignore)] bool taxExempt,
            [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)] object phone,
            [JsonProperty("email_marketing_consent", NullValueHandling = NullValueHandling.Ignore)] EmailMarketingConsent emailMarketingConsent,
            [JsonProperty("sms_marketing_consent", NullValueHandling = NullValueHandling.Ignore)] object smsMarketingConsent,
            [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)] string tags,
            [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)] string currency,
            [JsonProperty("accepts_marketing_updated_at", NullValueHandling = NullValueHandling.Ignore)] object acceptsMarketingUpdatedAt,
            [JsonProperty("marketing_opt_in_level", NullValueHandling = NullValueHandling.Ignore)] object marketingOptInLevel,
            [JsonProperty("tax_exemptions", NullValueHandling = NullValueHandling.Ignore)] List<object> taxExemptions,
            [JsonProperty("admin_graphql_api_id", NullValueHandling = NullValueHandling.Ignore)] string adminGraphqlApiId,
            [JsonProperty("default_address", NullValueHandling = NullValueHandling.Ignore)] DefaultAddress defaultAddress
        )
        {
            this.Id = id;
            this.Email = email;
            this.AcceptsMarketing = acceptsMarketing;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.State = state;
            this.Note = note;
            this.VerifiedEmail = verifiedEmail;
            this.MultipassIdentifier = multipassIdentifier;
            this.TaxExempt = taxExempt;
            this.Phone = phone;
            this.EmailMarketingConsent = emailMarketingConsent;
            this.SmsMarketingConsent = smsMarketingConsent;
            this.Tags = tags;
            this.Currency = currency;
            this.AcceptsMarketingUpdatedAt = acceptsMarketingUpdatedAt;
            this.MarketingOptInLevel = marketingOptInLevel;
            this.TaxExemptions = taxExemptions;
            this.AdminGraphqlApiId = adminGraphqlApiId;
            this.DefaultAddress = defaultAddress;
        }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long Id { get; }

        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; }

        [JsonProperty("accepts_marketing", NullValueHandling = NullValueHandling.Ignore)]
        public bool AcceptsMarketing { get; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public object CreatedAt { get; }

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public object UpdatedAt { get; }

        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; }

        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; }

        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; }

        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public object Note { get; }

        [JsonProperty("verified_email", NullValueHandling = NullValueHandling.Ignore)]
        public bool VerifiedEmail { get; }

        [JsonProperty("multipass_identifier", NullValueHandling = NullValueHandling.Ignore)]
        public object MultipassIdentifier { get; }

        [JsonProperty("tax_exempt", NullValueHandling = NullValueHandling.Ignore)]
        public bool TaxExempt { get; }

        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public object Phone { get; }

        [JsonProperty("email_marketing_consent", NullValueHandling = NullValueHandling.Ignore)]
        public EmailMarketingConsent EmailMarketingConsent { get; }

        [JsonProperty("sms_marketing_consent", NullValueHandling = NullValueHandling.Ignore)]
        public object SmsMarketingConsent { get; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; }

        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; }

        [JsonProperty("accepts_marketing_updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public object AcceptsMarketingUpdatedAt { get; }

        [JsonProperty("marketing_opt_in_level", NullValueHandling = NullValueHandling.Ignore)]
        public object MarketingOptInLevel { get; }

        [JsonProperty("tax_exemptions", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyList<object> TaxExemptions { get; }

        [JsonProperty("admin_graphql_api_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminGraphqlApiId { get; }

        [JsonProperty("default_address", NullValueHandling = NullValueHandling.Ignore)]
        public DefaultAddress DefaultAddress { get; }
    }

    public class DefaultAddress
    {
        [JsonConstructor]
        public DefaultAddress(
            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)] long id,
            [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)] long customerId,
            [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)] object firstName,
            [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)] object lastName,
            [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)] object company,
            [JsonProperty("address1", NullValueHandling = NullValueHandling.Ignore)] string address1,
            [JsonProperty("address2", NullValueHandling = NullValueHandling.Ignore)] object address2,
            [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)] string city,
            [JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)] string province,
            [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)] string country,
            [JsonProperty("zip", NullValueHandling = NullValueHandling.Ignore)] string zip,
            [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)] string phone,
            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)] string name,
            [JsonProperty("province_code", NullValueHandling = NullValueHandling.Ignore)] string provinceCode,
            [JsonProperty("country_code", NullValueHandling = NullValueHandling.Ignore)] string countryCode,
            [JsonProperty("country_name", NullValueHandling = NullValueHandling.Ignore)] string countryName,
            [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)] bool @default
        )
        {
            this.Id = id;
            this.CustomerId = customerId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Company = company;
            this.Address1 = address1;
            this.Address2 = address2;
            this.City = city;
            this.Province = province;
            this.Country = country;
            this.Zip = zip;
            this.Phone = phone;
            this.Name = name;
            this.ProvinceCode = provinceCode;
            this.CountryCode = countryCode;
            this.CountryName = countryName;
            this.Default = @default;
        }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long Id { get; }

        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public long CustomerId { get; }

        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public object FirstName { get; }

        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public object LastName { get; }

        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public object Company { get; }

        [JsonProperty("address1", NullValueHandling = NullValueHandling.Ignore)]
        public string Address1 { get; }

        [JsonProperty("address2", NullValueHandling = NullValueHandling.Ignore)]
        public object Address2 { get; }

        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; }

        [JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)]
        public string Province { get; }

        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; }

        [JsonProperty("zip", NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; }

        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; }

        [JsonProperty("province_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvinceCode { get; }

        [JsonProperty("country_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; }

        [JsonProperty("country_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryName { get; }

        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public bool Default { get; }
    }

    public class DiscountedPriceSet
    {
        [JsonConstructor]
        public DiscountedPriceSet(
            [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)] ShopMoney shopMoney,
            [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)] PresentmentMoney presentmentMoney
        )
        {
            this.ShopMoney = shopMoney;
            this.PresentmentMoney = presentmentMoney;
        }

        [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)]
        public ShopMoney ShopMoney { get; }

        [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)]
        public PresentmentMoney PresentmentMoney { get; }
    }

    public class EmailMarketingConsent
    {
        [JsonConstructor]
        public EmailMarketingConsent(
            [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)] string state,
            [JsonProperty("opt_in_level", NullValueHandling = NullValueHandling.Ignore)] object optInLevel,
            [JsonProperty("consent_updated_at", NullValueHandling = NullValueHandling.Ignore)] object consentUpdatedAt
        )
        {
            this.State = state;
            this.OptInLevel = optInLevel;
            this.ConsentUpdatedAt = consentUpdatedAt;
        }

        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; }

        [JsonProperty("opt_in_level", NullValueHandling = NullValueHandling.Ignore)]
        public object OptInLevel { get; }

        [JsonProperty("consent_updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public object ConsentUpdatedAt { get; }
    }

    public class LineItem
    {
        [JsonConstructor]
        public LineItem(
            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)] object id,
            [JsonProperty("admin_graphql_api_id", NullValueHandling = NullValueHandling.Ignore)] string adminGraphqlApiId,
            [JsonProperty("fulfillable_quantity", NullValueHandling = NullValueHandling.Ignore)] int fulfillableQuantity,
            [JsonProperty("fulfillment_service", NullValueHandling = NullValueHandling.Ignore)] string fulfillmentService,
            [JsonProperty("fulfillment_status", NullValueHandling = NullValueHandling.Ignore)] object fulfillmentStatus,
            [JsonProperty("gift_card", NullValueHandling = NullValueHandling.Ignore)] bool giftCard,
            [JsonProperty("grams", NullValueHandling = NullValueHandling.Ignore)] int grams,
            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)] string name,
            [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)] string price,
            [JsonProperty("price_set", NullValueHandling = NullValueHandling.Ignore)] PriceSet priceSet,
            [JsonProperty("product_exists", NullValueHandling = NullValueHandling.Ignore)] bool productExists,
            [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)] int productId,
            [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)] List<object> properties,
            [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)] int quantity,
            [JsonProperty("requires_shipping", NullValueHandling = NullValueHandling.Ignore)] bool requiresShipping,
            [JsonProperty("sku", NullValueHandling = NullValueHandling.Ignore)] string sku,
            [JsonProperty("taxable", NullValueHandling = NullValueHandling.Ignore)] bool taxable,
            [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)] string title,
            [JsonProperty("total_discount", NullValueHandling = NullValueHandling.Ignore)] string totalDiscount,
            [JsonProperty("total_discount_set", NullValueHandling = NullValueHandling.Ignore)] TotalDiscountSet totalDiscountSet,
            [JsonProperty("variant_id", NullValueHandling = NullValueHandling.Ignore)] int variantId,
            [JsonProperty("variant_inventory_management", NullValueHandling = NullValueHandling.Ignore)] string variantInventoryManagement,
            [JsonProperty("variant_title", NullValueHandling = NullValueHandling.Ignore)] object variantTitle,
            [JsonProperty("vendor", NullValueHandling = NullValueHandling.Ignore)] object vendor,
            [JsonProperty("tax_lines", NullValueHandling = NullValueHandling.Ignore)] List<object> taxLines,
            [JsonProperty("duties", NullValueHandling = NullValueHandling.Ignore)] List<object> duties,
            [JsonProperty("discount_allocations", NullValueHandling = NullValueHandling.Ignore)] List<object> discountAllocations
        )
        {
            this.Id = id;
            this.AdminGraphqlApiId = adminGraphqlApiId;
            this.FulfillableQuantity = fulfillableQuantity;
            this.FulfillmentService = fulfillmentService;
            this.FulfillmentStatus = fulfillmentStatus;
            this.GiftCard = giftCard;
            this.Grams = grams;
            this.Name = name;
            this.Price = price;
            this.PriceSet = priceSet;
            this.ProductExists = productExists;
            this.ProductId = productId;
            this.Properties = properties;
            this.Quantity = quantity;
            this.RequiresShipping = requiresShipping;
            this.Sku = sku;
            this.Taxable = taxable;
            this.Title = title;
            this.TotalDiscount = totalDiscount;
            this.TotalDiscountSet = totalDiscountSet;
            this.VariantId = variantId;
            this.VariantInventoryManagement = variantInventoryManagement;
            this.VariantTitle = variantTitle;
            this.Vendor = vendor;
            this.TaxLines = taxLines;
            this.Duties = duties;
            this.DiscountAllocations = discountAllocations;
        }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public object Id { get; }

        [JsonProperty("admin_graphql_api_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminGraphqlApiId { get; }

        [JsonProperty("fulfillable_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int FulfillableQuantity { get; }

        [JsonProperty("fulfillment_service", NullValueHandling = NullValueHandling.Ignore)]
        public string FulfillmentService { get; }

        [JsonProperty("fulfillment_status", NullValueHandling = NullValueHandling.Ignore)]
        public object FulfillmentStatus { get; }

        [JsonProperty("gift_card", NullValueHandling = NullValueHandling.Ignore)]
        public bool GiftCard { get; }

        [JsonProperty("grams", NullValueHandling = NullValueHandling.Ignore)]
        public int Grams { get; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; }

        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public string Price { get; }

        [JsonProperty("price_set", NullValueHandling = NullValueHandling.Ignore)]
        public PriceSet PriceSet { get; }

        [JsonProperty("product_exists", NullValueHandling = NullValueHandling.Ignore)]
        public bool ProductExists { get; }

        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public int ProductId { get; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyList<object> Properties { get; }

        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int Quantity { get; }

        [JsonProperty("requires_shipping", NullValueHandling = NullValueHandling.Ignore)]
        public bool RequiresShipping { get; }

        [JsonProperty("sku", NullValueHandling = NullValueHandling.Ignore)]
        public string Sku { get; }

        [JsonProperty("taxable", NullValueHandling = NullValueHandling.Ignore)]
        public bool Taxable { get; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; }

        [JsonProperty("total_discount", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalDiscount { get; }

        [JsonProperty("total_discount_set", NullValueHandling = NullValueHandling.Ignore)]
        public TotalDiscountSet TotalDiscountSet { get; }

        [JsonProperty("variant_id", NullValueHandling = NullValueHandling.Ignore)]
        public int VariantId { get; }

        [JsonProperty("variant_inventory_management", NullValueHandling = NullValueHandling.Ignore)]
        public string VariantInventoryManagement { get; }

        [JsonProperty("variant_title", NullValueHandling = NullValueHandling.Ignore)]
        public object VariantTitle { get; }

        [JsonProperty("vendor", NullValueHandling = NullValueHandling.Ignore)]
        public object Vendor { get; }

        [JsonProperty("tax_lines", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyList<object> TaxLines { get; }

        [JsonProperty("duties", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyList<object> Duties { get; }

        [JsonProperty("discount_allocations", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyList<object> DiscountAllocations { get; }
    }

    public class PresentmentMoney
    {
        [JsonConstructor]
        public PresentmentMoney(
            [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)] string amount,
            [JsonProperty("currency_code", NullValueHandling = NullValueHandling.Ignore)] string currencyCode
        )
        {
            this.Amount = amount;
            this.CurrencyCode = currencyCode;
        }

        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; }

        [JsonProperty("currency_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrencyCode { get; }
    }

    public class PriceSet
    {
        [JsonConstructor]
        public PriceSet(
            [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)] ShopMoney shopMoney,
            [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)] PresentmentMoney presentmentMoney
        )
        {
            this.ShopMoney = shopMoney;
            this.PresentmentMoney = presentmentMoney;
        }

        [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)]
        public ShopMoney ShopMoney { get; }

        [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)]
        public PresentmentMoney PresentmentMoney { get; }
    }

    public class ShopifyOrder
    {
        [JsonConstructor]
        public ShopifyOrder(
            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)] long id,
            [JsonProperty("admin_graphql_api_id", NullValueHandling = NullValueHandling.Ignore)] string adminGraphqlApiId,
            [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)] object appId,
            [JsonProperty("browser_ip", NullValueHandling = NullValueHandling.Ignore)] object browserIp,
            [JsonProperty("buyer_accepts_marketing", NullValueHandling = NullValueHandling.Ignore)] bool buyerAcceptsMarketing,
            [JsonProperty("cancel_reason", NullValueHandling = NullValueHandling.Ignore)] string cancelReason,
            [JsonProperty("cancelled_at", NullValueHandling = NullValueHandling.Ignore)] DateTime cancelledAt,
            [JsonProperty("cart_token", NullValueHandling = NullValueHandling.Ignore)] object cartToken,
            [JsonProperty("checkout_id", NullValueHandling = NullValueHandling.Ignore)] object checkoutId,
            [JsonProperty("checkout_token", NullValueHandling = NullValueHandling.Ignore)] object checkoutToken,
            [JsonProperty("client_details", NullValueHandling = NullValueHandling.Ignore)] object clientDetails,
            [JsonProperty("closed_at", NullValueHandling = NullValueHandling.Ignore)] object closedAt,
            [JsonProperty("confirmed", NullValueHandling = NullValueHandling.Ignore)] bool confirmed,
            [JsonProperty("contact_email", NullValueHandling = NullValueHandling.Ignore)] string contactEmail,
            [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)] DateTime createdAt,
            [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)] string currency,
            [JsonProperty("current_subtotal_price", NullValueHandling = NullValueHandling.Ignore)] string currentSubtotalPrice,
            [JsonProperty("current_subtotal_price_set", NullValueHandling = NullValueHandling.Ignore)] CurrentSubtotalPriceSet currentSubtotalPriceSet,
            [JsonProperty("current_total_additional_fees_set", NullValueHandling = NullValueHandling.Ignore)] object currentTotalAdditionalFeesSet,
            [JsonProperty("current_total_discounts", NullValueHandling = NullValueHandling.Ignore)] string currentTotalDiscounts,
            [JsonProperty("current_total_discounts_set", NullValueHandling = NullValueHandling.Ignore)] CurrentTotalDiscountsSet currentTotalDiscountsSet,
            [JsonProperty("current_total_duties_set", NullValueHandling = NullValueHandling.Ignore)] object currentTotalDutiesSet,
            [JsonProperty("current_total_price", NullValueHandling = NullValueHandling.Ignore)] string currentTotalPrice,
            [JsonProperty("current_total_price_set", NullValueHandling = NullValueHandling.Ignore)] CurrentTotalPriceSet currentTotalPriceSet,
            [JsonProperty("current_total_tax", NullValueHandling = NullValueHandling.Ignore)] string currentTotalTax,
            [JsonProperty("current_total_tax_set", NullValueHandling = NullValueHandling.Ignore)] CurrentTotalTaxSet currentTotalTaxSet,
            [JsonProperty("customer_locale", NullValueHandling = NullValueHandling.Ignore)] string customerLocale,
            [JsonProperty("device_id", NullValueHandling = NullValueHandling.Ignore)] object deviceId,
            [JsonProperty("discount_codes", NullValueHandling = NullValueHandling.Ignore)] List<object> discountCodes,
            [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)] string email,
            [JsonProperty("estimated_taxes", NullValueHandling = NullValueHandling.Ignore)] bool estimatedTaxes,
            [JsonProperty("financial_status", NullValueHandling = NullValueHandling.Ignore)] string financialStatus,
            [JsonProperty("fulfillment_status", NullValueHandling = NullValueHandling.Ignore)] string fulfillmentStatus,
            [JsonProperty("landing_site", NullValueHandling = NullValueHandling.Ignore)] object landingSite,
            [JsonProperty("landing_site_ref", NullValueHandling = NullValueHandling.Ignore)] object landingSiteRef,
            [JsonProperty("location_id", NullValueHandling = NullValueHandling.Ignore)] object locationId,
            [JsonProperty("merchant_of_record_app_id", NullValueHandling = NullValueHandling.Ignore)] object merchantOfRecordAppId,
            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)] string name,
            [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)] object note,
            [JsonProperty("note_attributes", NullValueHandling = NullValueHandling.Ignore)] List<object> noteAttributes,
            [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)] int number,
            [JsonProperty("order_number", NullValueHandling = NullValueHandling.Ignore)] int orderNumber,
            [JsonProperty("order_status_url", NullValueHandling = NullValueHandling.Ignore)] string orderStatusUrl,
            [JsonProperty("original_total_additional_fees_set", NullValueHandling = NullValueHandling.Ignore)] object originalTotalAdditionalFeesSet,
            [JsonProperty("original_total_duties_set", NullValueHandling = NullValueHandling.Ignore)] object originalTotalDutiesSet,
            [JsonProperty("payment_gateway_names", NullValueHandling = NullValueHandling.Ignore)] List<string> paymentGatewayNames,
            [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)] object phone,
            [JsonProperty("presentment_currency", NullValueHandling = NullValueHandling.Ignore)] string presentmentCurrency,
            [JsonProperty("processed_at", NullValueHandling = NullValueHandling.Ignore)] object processedAt,
            [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)] object reference,
            [JsonProperty("referring_site", NullValueHandling = NullValueHandling.Ignore)] object referringSite,
            [JsonProperty("source_identifier", NullValueHandling = NullValueHandling.Ignore)] object sourceIdentifier,
            [JsonProperty("source_name", NullValueHandling = NullValueHandling.Ignore)] string sourceName,
            [JsonProperty("source_url", NullValueHandling = NullValueHandling.Ignore)] object sourceUrl,
            [JsonProperty("subtotal_price", NullValueHandling = NullValueHandling.Ignore)] string subtotalPrice,
            [JsonProperty("subtotal_price_set", NullValueHandling = NullValueHandling.Ignore)] SubtotalPriceSet subtotalPriceSet,
            [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)] string tags,
            [JsonProperty("tax_lines", NullValueHandling = NullValueHandling.Ignore)] List<object> taxLines,
            [JsonProperty("taxes_included", NullValueHandling = NullValueHandling.Ignore)] bool taxesIncluded,
            [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)] bool test,
            [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)] string token,
            [JsonProperty("total_discounts", NullValueHandling = NullValueHandling.Ignore)] string totalDiscounts,
            [JsonProperty("total_discounts_set", NullValueHandling = NullValueHandling.Ignore)] TotalDiscountsSet totalDiscountsSet,
            [JsonProperty("total_line_items_price", NullValueHandling = NullValueHandling.Ignore)] string totalLineItemsPrice,
            [JsonProperty("total_line_items_price_set", NullValueHandling = NullValueHandling.Ignore)] TotalLineItemsPriceSet totalLineItemsPriceSet,
            [JsonProperty("total_outstanding", NullValueHandling = NullValueHandling.Ignore)] string totalOutstanding,
            [JsonProperty("total_price", NullValueHandling = NullValueHandling.Ignore)] string totalPrice,
            [JsonProperty("total_price_set", NullValueHandling = NullValueHandling.Ignore)] TotalPriceSet totalPriceSet,
            [JsonProperty("total_shipping_price_set", NullValueHandling = NullValueHandling.Ignore)] TotalShippingPriceSet totalShippingPriceSet,
            [JsonProperty("total_tax", NullValueHandling = NullValueHandling.Ignore)] string totalTax,
            [JsonProperty("total_tax_set", NullValueHandling = NullValueHandling.Ignore)] TotalTaxSet totalTaxSet,
            [JsonProperty("total_tip_received", NullValueHandling = NullValueHandling.Ignore)] string totalTipReceived,
            [JsonProperty("total_weight", NullValueHandling = NullValueHandling.Ignore)] int totalWeight,
            [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)] DateTime updatedAt,
            [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)] object userId,
            [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)] BillingAddress billingAddress,
            [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)] Customer customer,
            [JsonProperty("discount_applications", NullValueHandling = NullValueHandling.Ignore)] List<object> discountApplications,
            [JsonProperty("fulfillments", NullValueHandling = NullValueHandling.Ignore)] List<object> fulfillments,
            [JsonProperty("line_items", NullValueHandling = NullValueHandling.Ignore)] List<LineItem> lineItems,
            [JsonProperty("payment_terms", NullValueHandling = NullValueHandling.Ignore)] object paymentTerms,
            [JsonProperty("refunds", NullValueHandling = NullValueHandling.Ignore)] List<object> refunds,
            [JsonProperty("shipping_address", NullValueHandling = NullValueHandling.Ignore)] ShippingAddress shippingAddress,
            [JsonProperty("shipping_lines", NullValueHandling = NullValueHandling.Ignore)] List<ShippingLine> shippingLines
        )
        {
            this.Id = id;
            this.AdminGraphqlApiId = adminGraphqlApiId;
            this.AppId = appId;
            this.BrowserIp = browserIp;
            this.BuyerAcceptsMarketing = buyerAcceptsMarketing;
            this.CancelReason = cancelReason;
            this.CancelledAt = cancelledAt;
            this.CartToken = cartToken;
            this.CheckoutId = checkoutId;
            this.CheckoutToken = checkoutToken;
            this.ClientDetails = clientDetails;
            this.ClosedAt = closedAt;
            this.Confirmed = confirmed;
            this.ContactEmail = contactEmail;
            this.CreatedAt = createdAt;
            this.Currency = currency;
            this.CurrentSubtotalPrice = currentSubtotalPrice;
            this.CurrentSubtotalPriceSet = currentSubtotalPriceSet;
            this.CurrentTotalAdditionalFeesSet = currentTotalAdditionalFeesSet;
            this.CurrentTotalDiscounts = currentTotalDiscounts;
            this.CurrentTotalDiscountsSet = currentTotalDiscountsSet;
            this.CurrentTotalDutiesSet = currentTotalDutiesSet;
            this.CurrentTotalPrice = currentTotalPrice;
            this.CurrentTotalPriceSet = currentTotalPriceSet;
            this.CurrentTotalTax = currentTotalTax;
            this.CurrentTotalTaxSet = currentTotalTaxSet;
            this.CustomerLocale = customerLocale;
            this.DeviceId = deviceId;
            this.DiscountCodes = discountCodes;
            this.Email = email;
            this.EstimatedTaxes = estimatedTaxes;
            this.FinancialStatus = financialStatus;
            this.FulfillmentStatus = fulfillmentStatus;
            this.LandingSite = landingSite;
            this.LandingSiteRef = landingSiteRef;
            this.LocationId = locationId;
            this.MerchantOfRecordAppId = merchantOfRecordAppId;
            this.Name = name;
            this.Note = note;
            this.NoteAttributes = noteAttributes;
            this.Number = number;
            this.OrderNumber = orderNumber;
            this.OrderStatusUrl = orderStatusUrl;
            this.OriginalTotalAdditionalFeesSet = originalTotalAdditionalFeesSet;
            this.OriginalTotalDutiesSet = originalTotalDutiesSet;
            this.PaymentGatewayNames = paymentGatewayNames;
            this.Phone = phone;
            this.PresentmentCurrency = presentmentCurrency;
            this.ProcessedAt = processedAt;
            this.Reference = reference;
            this.ReferringSite = referringSite;
            this.SourceIdentifier = sourceIdentifier;
            this.SourceName = sourceName;
            this.SourceUrl = sourceUrl;
            this.SubtotalPrice = subtotalPrice;
            this.SubtotalPriceSet = subtotalPriceSet;
            this.Tags = tags;
            this.TaxLines = taxLines;
            this.TaxesIncluded = taxesIncluded;
            this.Test = test;
            this.Token = token;
            this.TotalDiscounts = totalDiscounts;
            this.TotalDiscountsSet = totalDiscountsSet;
            this.TotalLineItemsPrice = totalLineItemsPrice;
            this.TotalLineItemsPriceSet = totalLineItemsPriceSet;
            this.TotalOutstanding = totalOutstanding;
            this.TotalPrice = totalPrice;
            this.TotalPriceSet = totalPriceSet;
            this.TotalShippingPriceSet = totalShippingPriceSet;
            this.TotalTax = totalTax;
            this.TotalTaxSet = totalTaxSet;
            this.TotalTipReceived = totalTipReceived;
            this.TotalWeight = totalWeight;
            this.UpdatedAt = updatedAt;
            this.UserId = userId;
            this.BillingAddress = billingAddress;
            this.Customer = customer;
            this.DiscountApplications = discountApplications;
            this.Fulfillments = fulfillments;
            this.LineItems = lineItems;
            this.PaymentTerms = paymentTerms;
            this.Refunds = refunds;
            this.ShippingAddress = shippingAddress;
            this.ShippingLines = shippingLines;
        }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long Id { get; }

        [JsonProperty("admin_graphql_api_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AdminGraphqlApiId { get; }

        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public object AppId { get; }

        [JsonProperty("browser_ip", NullValueHandling = NullValueHandling.Ignore)]
        public object BrowserIp { get; }

        [JsonProperty("buyer_accepts_marketing", NullValueHandling = NullValueHandling.Ignore)]
        public bool BuyerAcceptsMarketing { get; }

        [JsonProperty("cancel_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string CancelReason { get; }

        [JsonProperty("cancelled_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CancelledAt { get; }

        [JsonProperty("cart_token", NullValueHandling = NullValueHandling.Ignore)]
        public object CartToken { get; }

        [JsonProperty("checkout_id", NullValueHandling = NullValueHandling.Ignore)]
        public object CheckoutId { get; }

        [JsonProperty("checkout_token", NullValueHandling = NullValueHandling.Ignore)]
        public object CheckoutToken { get; }

        [JsonProperty("client_details", NullValueHandling = NullValueHandling.Ignore)]
        public object ClientDetails { get; }

        [JsonProperty("closed_at", NullValueHandling = NullValueHandling.Ignore)]
        public object ClosedAt { get; }

        [JsonProperty("confirmed", NullValueHandling = NullValueHandling.Ignore)]
        public bool Confirmed { get; }

        [JsonProperty("contact_email", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactEmail { get; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime CreatedAt { get; }

        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; }

        [JsonProperty("current_subtotal_price", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentSubtotalPrice { get; }

        [JsonProperty("current_subtotal_price_set", NullValueHandling = NullValueHandling.Ignore)]
        public CurrentSubtotalPriceSet CurrentSubtotalPriceSet { get; }

        [JsonProperty("current_total_additional_fees_set", NullValueHandling = NullValueHandling.Ignore)]
        public object CurrentTotalAdditionalFeesSet { get; }

        [JsonProperty("current_total_discounts", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentTotalDiscounts { get; }

        [JsonProperty("current_total_discounts_set", NullValueHandling = NullValueHandling.Ignore)]
        public CurrentTotalDiscountsSet CurrentTotalDiscountsSet { get; }

        [JsonProperty("current_total_duties_set", NullValueHandling = NullValueHandling.Ignore)]
        public object CurrentTotalDutiesSet { get; }

        [JsonProperty("current_total_price", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentTotalPrice { get; }

        [JsonProperty("current_total_price_set", NullValueHandling = NullValueHandling.Ignore)]
        public CurrentTotalPriceSet CurrentTotalPriceSet { get; }

        [JsonProperty("current_total_tax", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentTotalTax { get; }

        [JsonProperty("current_total_tax_set", NullValueHandling = NullValueHandling.Ignore)]
        public CurrentTotalTaxSet CurrentTotalTaxSet { get; }

        [JsonProperty("customer_locale", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerLocale { get; }

        [JsonProperty("device_id", NullValueHandling = NullValueHandling.Ignore)]
        public object DeviceId { get; }

        [JsonProperty("discount_codes", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyList<object> DiscountCodes { get; }

        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; }

        [JsonProperty("estimated_taxes", NullValueHandling = NullValueHandling.Ignore)]
        public bool EstimatedTaxes { get; }

        [JsonProperty("financial_status", NullValueHandling = NullValueHandling.Ignore)]
        public string FinancialStatus { get; }

        [JsonProperty("fulfillment_status", NullValueHandling = NullValueHandling.Ignore)]
        public string FulfillmentStatus { get; }

        [JsonProperty("landing_site", NullValueHandling = NullValueHandling.Ignore)]
        public object LandingSite { get; }

        [JsonProperty("landing_site_ref", NullValueHandling = NullValueHandling.Ignore)]
        public object LandingSiteRef { get; }

        [JsonProperty("location_id", NullValueHandling = NullValueHandling.Ignore)]
        public object LocationId { get; }

        [JsonProperty("merchant_of_record_app_id", NullValueHandling = NullValueHandling.Ignore)]
        public object MerchantOfRecordAppId { get; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; }

        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public object Note { get; }

        [JsonProperty("note_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyList<object> NoteAttributes { get; }

        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public int Number { get; }

        [JsonProperty("order_number", NullValueHandling = NullValueHandling.Ignore)]
        public int OrderNumber { get; }

        [JsonProperty("order_status_url", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderStatusUrl { get; }

        [JsonProperty("original_total_additional_fees_set", NullValueHandling = NullValueHandling.Ignore)]
        public object OriginalTotalAdditionalFeesSet { get; }

        [JsonProperty("original_total_duties_set", NullValueHandling = NullValueHandling.Ignore)]
        public object OriginalTotalDutiesSet { get; }

        [JsonProperty("payment_gateway_names", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyList<string> PaymentGatewayNames { get; }

        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public object Phone { get; }

        [JsonProperty("presentment_currency", NullValueHandling = NullValueHandling.Ignore)]
        public string PresentmentCurrency { get; }

        [JsonProperty("processed_at", NullValueHandling = NullValueHandling.Ignore)]
        public object ProcessedAt { get; }

        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public object Reference { get; }

        [JsonProperty("referring_site", NullValueHandling = NullValueHandling.Ignore)]
        public object ReferringSite { get; }

        [JsonProperty("source_identifier", NullValueHandling = NullValueHandling.Ignore)]
        public object SourceIdentifier { get; }

        [JsonProperty("source_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceName { get; }

        [JsonProperty("source_url", NullValueHandling = NullValueHandling.Ignore)]
        public object SourceUrl { get; }

        [JsonProperty("subtotal_price", NullValueHandling = NullValueHandling.Ignore)]
        public string SubtotalPrice { get; }

        [JsonProperty("subtotal_price_set", NullValueHandling = NullValueHandling.Ignore)]
        public SubtotalPriceSet SubtotalPriceSet { get; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; }

        [JsonProperty("tax_lines", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyList<object> TaxLines { get; }

        [JsonProperty("taxes_included", NullValueHandling = NullValueHandling.Ignore)]
        public bool TaxesIncluded { get; }

        [JsonProperty("test", NullValueHandling = NullValueHandling.Ignore)]
        public bool Test { get; }

        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; }

        [JsonProperty("total_discounts", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalDiscounts { get; }

        [JsonProperty("total_discounts_set", NullValueHandling = NullValueHandling.Ignore)]
        public TotalDiscountsSet TotalDiscountsSet { get; }

        [JsonProperty("total_line_items_price", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalLineItemsPrice { get; }

        [JsonProperty("total_line_items_price_set", NullValueHandling = NullValueHandling.Ignore)]
        public TotalLineItemsPriceSet TotalLineItemsPriceSet { get; }

        [JsonProperty("total_outstanding", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalOutstanding { get; }

        [JsonProperty("total_price", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalPrice { get; }

        [JsonProperty("total_price_set", NullValueHandling = NullValueHandling.Ignore)]
        public TotalPriceSet TotalPriceSet { get; }

        [JsonProperty("total_shipping_price_set", NullValueHandling = NullValueHandling.Ignore)]
        public TotalShippingPriceSet TotalShippingPriceSet { get; }

        [JsonProperty("total_tax", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalTax { get; }

        [JsonProperty("total_tax_set", NullValueHandling = NullValueHandling.Ignore)]
        public TotalTaxSet TotalTaxSet { get; }

        [JsonProperty("total_tip_received", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalTipReceived { get; }

        [JsonProperty("total_weight", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalWeight { get; }

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime UpdatedAt { get; }

        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public object UserId { get; }

        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public BillingAddress BillingAddress { get; }

        [JsonProperty("customer", NullValueHandling = NullValueHandling.Ignore)]
        public Customer Customer { get; }

        [JsonProperty("discount_applications", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyList<object> DiscountApplications { get; }

        [JsonProperty("fulfillments", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyList<object> Fulfillments { get; }

        [JsonProperty("line_items", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyList<LineItem> LineItems { get; }

        [JsonProperty("payment_terms", NullValueHandling = NullValueHandling.Ignore)]
        public object PaymentTerms { get; }

        [JsonProperty("refunds", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyList<object> Refunds { get; }

        [JsonProperty("shipping_address", NullValueHandling = NullValueHandling.Ignore)]
        public ShippingAddress ShippingAddress { get; }

        [JsonProperty("shipping_lines", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyList<ShippingLine> ShippingLines { get; }
    }

    public class ShippingAddress
    {
        [JsonConstructor]
        public ShippingAddress(
            [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)] string firstName,
            [JsonProperty("address1", NullValueHandling = NullValueHandling.Ignore)] string address1,
            [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)] string phone,
            [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)] string city,
            [JsonProperty("zip", NullValueHandling = NullValueHandling.Ignore)] string zip,
            [JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)] string province,
            [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)] string country,
            [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)] string lastName,
            [JsonProperty("address2", NullValueHandling = NullValueHandling.Ignore)] object address2,
            [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)] string company,
            [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)] object latitude,
            [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)] object longitude,
            [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)] string name,
            [JsonProperty("country_code", NullValueHandling = NullValueHandling.Ignore)] string countryCode,
            [JsonProperty("province_code", NullValueHandling = NullValueHandling.Ignore)] string provinceCode
        )
        {
            this.FirstName = firstName;
            this.Address1 = address1;
            this.Phone = phone;
            this.City = city;
            this.Zip = zip;
            this.Province = province;
            this.Country = country;
            this.LastName = lastName;
            this.Address2 = address2;
            this.Company = company;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Name = name;
            this.CountryCode = countryCode;
            this.ProvinceCode = provinceCode;
        }

        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; }

        [JsonProperty("address1", NullValueHandling = NullValueHandling.Ignore)]
        public string Address1 { get; }

        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; }

        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; }

        [JsonProperty("zip", NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; }

        [JsonProperty("province", NullValueHandling = NullValueHandling.Ignore)]
        public string Province { get; }

        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; }

        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; }

        [JsonProperty("address2", NullValueHandling = NullValueHandling.Ignore)]
        public object Address2 { get; }

        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public string Company { get; }

        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        public object Latitude { get; }

        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        public object Longitude { get; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; }

        [JsonProperty("country_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CountryCode { get; }

        [JsonProperty("province_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvinceCode { get; }
    }

    public class ShippingLine
    {
        [JsonConstructor]
        public ShippingLine(
            [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)] long id,
            [JsonProperty("carrier_identifier", NullValueHandling = NullValueHandling.Ignore)] object carrierIdentifier,
            [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)] object code,
            [JsonProperty("delivery_category", NullValueHandling = NullValueHandling.Ignore)] object deliveryCategory,
            [JsonProperty("discounted_price", NullValueHandling = NullValueHandling.Ignore)] string discountedPrice,
            [JsonProperty("discounted_price_set", NullValueHandling = NullValueHandling.Ignore)] DiscountedPriceSet discountedPriceSet,
            [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)] object phone,
            [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)] string price,
            [JsonProperty("price_set", NullValueHandling = NullValueHandling.Ignore)] PriceSet priceSet,
            [JsonProperty("requested_fulfillment_service_id", NullValueHandling = NullValueHandling.Ignore)] object requestedFulfillmentServiceId,
            [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)] string source,
            [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)] string title,
            [JsonProperty("tax_lines", NullValueHandling = NullValueHandling.Ignore)] List<object> taxLines,
            [JsonProperty("discount_allocations", NullValueHandling = NullValueHandling.Ignore)] List<object> discountAllocations
        )
        {
            this.Id = id;
            this.CarrierIdentifier = carrierIdentifier;
            this.Code = code;
            this.DeliveryCategory = deliveryCategory;
            this.DiscountedPrice = discountedPrice;
            this.DiscountedPriceSet = discountedPriceSet;
            this.Phone = phone;
            this.Price = price;
            this.PriceSet = priceSet;
            this.RequestedFulfillmentServiceId = requestedFulfillmentServiceId;
            this.Source = source;
            this.Title = title;
            this.TaxLines = taxLines;
            this.DiscountAllocations = discountAllocations;
        }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long Id { get; }

        [JsonProperty("carrier_identifier", NullValueHandling = NullValueHandling.Ignore)]
        public object CarrierIdentifier { get; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public object Code { get; }

        [JsonProperty("delivery_category", NullValueHandling = NullValueHandling.Ignore)]
        public object DeliveryCategory { get; }

        [JsonProperty("discounted_price", NullValueHandling = NullValueHandling.Ignore)]
        public string DiscountedPrice { get; }

        [JsonProperty("discounted_price_set", NullValueHandling = NullValueHandling.Ignore)]
        public DiscountedPriceSet DiscountedPriceSet { get; }

        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public object Phone { get; }

        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public string Price { get; }

        [JsonProperty("price_set", NullValueHandling = NullValueHandling.Ignore)]
        public PriceSet PriceSet { get; }

        [JsonProperty("requested_fulfillment_service_id", NullValueHandling = NullValueHandling.Ignore)]
        public object RequestedFulfillmentServiceId { get; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; }

        [JsonProperty("tax_lines", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyList<object> TaxLines { get; }

        [JsonProperty("discount_allocations", NullValueHandling = NullValueHandling.Ignore)]
        public IReadOnlyList<object> DiscountAllocations { get; }
    }

    public class ShopMoney
    {
        [JsonConstructor]
        public ShopMoney(
            [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)] string amount,
            [JsonProperty("currency_code", NullValueHandling = NullValueHandling.Ignore)] string currencyCode
        )
        {
            this.Amount = amount;
            this.CurrencyCode = currencyCode;
        }

        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; }

        [JsonProperty("currency_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrencyCode { get; }
    }

    public class SubtotalPriceSet
    {
        [JsonConstructor]
        public SubtotalPriceSet(
            [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)] ShopMoney shopMoney,
            [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)] PresentmentMoney presentmentMoney
        )
        {
            this.ShopMoney = shopMoney;
            this.PresentmentMoney = presentmentMoney;
        }

        [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)]
        public ShopMoney ShopMoney { get; }

        [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)]
        public PresentmentMoney PresentmentMoney { get; }
    }

    public class TotalDiscountSet
    {
        [JsonConstructor]
        public TotalDiscountSet(
            [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)] ShopMoney shopMoney,
            [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)] PresentmentMoney presentmentMoney
        )
        {
            this.ShopMoney = shopMoney;
            this.PresentmentMoney = presentmentMoney;
        }

        [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)]
        public ShopMoney ShopMoney { get; }

        [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)]
        public PresentmentMoney PresentmentMoney { get; }
    }

    public class TotalDiscountsSet
    {
        [JsonConstructor]
        public TotalDiscountsSet(
            [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)] ShopMoney shopMoney,
            [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)] PresentmentMoney presentmentMoney
        )
        {
            this.ShopMoney = shopMoney;
            this.PresentmentMoney = presentmentMoney;
        }

        [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)]
        public ShopMoney ShopMoney { get; }

        [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)]
        public PresentmentMoney PresentmentMoney { get; }
    }

    public class TotalLineItemsPriceSet
    {
        [JsonConstructor]
        public TotalLineItemsPriceSet(
            [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)] ShopMoney shopMoney,
            [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)] PresentmentMoney presentmentMoney
        )
        {
            this.ShopMoney = shopMoney;
            this.PresentmentMoney = presentmentMoney;
        }

        [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)]
        public ShopMoney ShopMoney { get; }

        [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)]
        public PresentmentMoney PresentmentMoney { get; }
    }

    public class TotalPriceSet
    {
        [JsonConstructor]
        public TotalPriceSet(
            [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)] ShopMoney shopMoney,
            [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)] PresentmentMoney presentmentMoney
        )
        {
            this.ShopMoney = shopMoney;
            this.PresentmentMoney = presentmentMoney;
        }

        [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)]
        public ShopMoney ShopMoney { get; }

        [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)]
        public PresentmentMoney PresentmentMoney { get; }
    }

    public class TotalShippingPriceSet
    {
        [Newtonsoft.Json.JsonConstructor]
        public TotalShippingPriceSet(
            [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)] ShopMoney shopMoney,
            [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)] PresentmentMoney presentmentMoney
        )
        {
            this.ShopMoney = shopMoney;
            this.PresentmentMoney = presentmentMoney;
        }

        [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)]
        public ShopMoney ShopMoney { get; }

        [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)]
        public PresentmentMoney PresentmentMoney { get; }
    }

    public class TotalTaxSet
    {
        [JsonConstructor]
        public TotalTaxSet(
            [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)] ShopMoney shopMoney,
            [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)] PresentmentMoney presentmentMoney
        )
        {
            this.ShopMoney = shopMoney;
            this.PresentmentMoney = presentmentMoney;
        }

        [JsonProperty("shop_money", NullValueHandling = NullValueHandling.Ignore)]
        public ShopMoney ShopMoney { get; }

        [JsonProperty("presentment_money", NullValueHandling = NullValueHandling.Ignore)]
        public PresentmentMoney PresentmentMoney { get; }
    }




}
