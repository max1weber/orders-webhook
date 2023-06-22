using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace func_orders_webhook.entity
{
    public class BillingAddress
    {
        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string FirstName;

        [JsonProperty("address1")]
        [JsonPropertyName("address1")]
        public string Address1;

        [JsonProperty("phone")]
        [JsonPropertyName("phone")]
        public string Phone;

        [JsonProperty("city")]
        [JsonPropertyName("city")]
        public string City;

        [JsonProperty("zip")]
        [JsonPropertyName("zip")]
        public string Zip;

        [JsonProperty("province")]
        [JsonPropertyName("province")]
        public string Province;

        [JsonProperty("country")]
        [JsonPropertyName("country")]
        public string Country;

        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string LastName;

        [JsonProperty("address2")]
        [JsonPropertyName("address2")]
        public object Address2;

        [JsonProperty("company")]
        [JsonPropertyName("company")]
        public string Company;

        [JsonProperty("latitude")]
        [JsonPropertyName("latitude")]
        public object Latitude;

        [JsonProperty("longitude")]
        [JsonPropertyName("longitude")]
        public object Longitude;

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name;

        [JsonProperty("country_code")]
        [JsonPropertyName("country_code")]
        public string CountryCode;

        [JsonProperty("province_code")]
        [JsonPropertyName("province_code")]
        public string ProvinceCode;
    }

    public class CurrentSubtotalPriceSet
    {
        [JsonProperty("shop_money")]
        [JsonPropertyName("shop_money")]
        public ShopMoney ShopMoney;

        [JsonProperty("presentment_money")]
        [JsonPropertyName("presentment_money")]
        public PresentmentMoney PresentmentMoney;
    }

    public class CurrentTotalDiscountsSet
    {
        [JsonProperty("shop_money")]
        [JsonPropertyName("shop_money")]
        public ShopMoney ShopMoney;

        [JsonProperty("presentment_money")]
        [JsonPropertyName("presentment_money")]
        public PresentmentMoney PresentmentMoney;
    }

    public class CurrentTotalPriceSet
    {
        [JsonProperty("shop_money")]
        [JsonPropertyName("shop_money")]
        public ShopMoney ShopMoney;

        [JsonProperty("presentment_money")]
        [JsonPropertyName("presentment_money")]
        public PresentmentMoney PresentmentMoney;
    }

    public class CurrentTotalTaxSet
    {
        [JsonProperty("shop_money")]
        [JsonPropertyName("shop_money")]
        public ShopMoney ShopMoney;

        [JsonProperty("presentment_money")]
        [JsonPropertyName("presentment_money")]
        public PresentmentMoney PresentmentMoney;
    }

    public class Customer
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public long Id;

        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email;

        [JsonProperty("accepts_marketing")]
        [JsonPropertyName("accepts_marketing")]
        public bool AcceptsMarketing;

        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public object CreatedAt;

        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public object UpdatedAt;

        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string FirstName;

        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string LastName;

        [JsonProperty("state")]
        [JsonPropertyName("state")]
        public string State;

        [JsonProperty("note")]
        [JsonPropertyName("note")]
        public object Note;

        [JsonProperty("verified_email")]
        [JsonPropertyName("verified_email")]
        public bool VerifiedEmail;

        [JsonProperty("multipass_identifier")]
        [JsonPropertyName("multipass_identifier")]
        public object MultipassIdentifier;

        [JsonProperty("tax_exempt")]
        [JsonPropertyName("tax_exempt")]
        public bool TaxExempt;

        [JsonProperty("phone")]
        [JsonPropertyName("phone")]
        public object Phone;

        [JsonProperty("email_marketing_consent")]
        [JsonPropertyName("email_marketing_consent")]
        public EmailMarketingConsent EmailMarketingConsent;

        [JsonProperty("sms_marketing_consent")]
        [JsonPropertyName("sms_marketing_consent")]
        public object SmsMarketingConsent;

        [JsonProperty("tags")]
        [JsonPropertyName("tags")]
        public string Tags;

        [JsonProperty("currency")]
        [JsonPropertyName("currency")]
        public string Currency;

        [JsonProperty("accepts_marketing_updated_at")]
        [JsonPropertyName("accepts_marketing_updated_at")]
        public object AcceptsMarketingUpdatedAt;

        [JsonProperty("marketing_opt_in_level")]
        [JsonPropertyName("marketing_opt_in_level")]
        public object MarketingOptInLevel;

        [JsonProperty("tax_exemptions")]
        [JsonPropertyName("tax_exemptions")]
        public List<object> TaxExemptions;

        [JsonProperty("admin_graphql_api_id")]
        [JsonPropertyName("admin_graphql_api_id")]
        public string AdminGraphqlApiId;

        [JsonProperty("default_address")]
        [JsonPropertyName("default_address")]
        public DefaultAddress DefaultAddress;
    }

    public class DefaultAddress
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public long Id;

        [JsonProperty("customer_id")]
        [JsonPropertyName("customer_id")]
        public long CustomerId;

        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public object FirstName;

        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public object LastName;

        [JsonProperty("company")]
        [JsonPropertyName("company")]
        public object Company;

        [JsonProperty("address1")]
        [JsonPropertyName("address1")]
        public string Address1;

        [JsonProperty("address2")]
        [JsonPropertyName("address2")]
        public object Address2;

        [JsonProperty("city")]
        [JsonPropertyName("city")]
        public string City;

        [JsonProperty("province")]
        [JsonPropertyName("province")]
        public string Province;

        [JsonProperty("country")]
        [JsonPropertyName("country")]
        public string Country;

        [JsonProperty("zip")]
        [JsonPropertyName("zip")]
        public string Zip;

        [JsonProperty("phone")]
        [JsonPropertyName("phone")]
        public string Phone;

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name;

        [JsonProperty("province_code")]
        [JsonPropertyName("province_code")]
        public string ProvinceCode;

        [JsonProperty("country_code")]
        [JsonPropertyName("country_code")]
        public string CountryCode;

        [JsonProperty("country_name")]
        [JsonPropertyName("country_name")]
        public string CountryName;

        [JsonProperty("default")]
        [JsonPropertyName("default")]
        public bool Default;
    }

    public class DiscountedPriceSet
    {
        [JsonProperty("shop_money")]
        [JsonPropertyName("shop_money")]
        public ShopMoney ShopMoney;

        [JsonProperty("presentment_money")]
        [JsonPropertyName("presentment_money")]
        public PresentmentMoney PresentmentMoney;
    }

    public class EmailMarketingConsent
    {
        [JsonProperty("state")]
        [JsonPropertyName("state")]
        public string State;

        [JsonProperty("opt_in_level")]
        [JsonPropertyName("opt_in_level")]
        public object OptInLevel;

        [JsonProperty("consent_updated_at")]
        [JsonPropertyName("consent_updated_at")]
        public object ConsentUpdatedAt;
    }

    public class LineItem
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public object Id;

        [JsonProperty("admin_graphql_api_id")]
        [JsonPropertyName("admin_graphql_api_id")]
        public string AdminGraphqlApiId;

        [JsonProperty("fulfillable_quantity")]
        [JsonPropertyName("fulfillable_quantity")]
        public int FulfillableQuantity;

        [JsonProperty("fulfillment_service")]
        [JsonPropertyName("fulfillment_service")]
        public string FulfillmentService;

        [JsonProperty("fulfillment_status")]
        [JsonPropertyName("fulfillment_status")]
        public object FulfillmentStatus;

        [JsonProperty("gift_card")]
        [JsonPropertyName("gift_card")]
        public bool GiftCard;

        [JsonProperty("grams")]
        [JsonPropertyName("grams")]
        public int Grams;

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name;

        [JsonProperty("price")]
        [JsonPropertyName("price")]
        public string Price;

        [JsonProperty("price_set")]
        [JsonPropertyName("price_set")]
        public PriceSet PriceSet;

        [JsonProperty("product_exists")]
        [JsonPropertyName("product_exists")]
        public bool ProductExists;

        [JsonProperty("product_id")]
        [JsonPropertyName("product_id")]
        public int ProductId;

        [JsonProperty("properties")]
        [JsonPropertyName("properties")]
        public List<object> Properties;

        [JsonProperty("quantity")]
        [JsonPropertyName("quantity")]
        public int Quantity;

        [JsonProperty("requires_shipping")]
        [JsonPropertyName("requires_shipping")]
        public bool RequiresShipping;

        [JsonProperty("sku")]
        [JsonPropertyName("sku")]
        public string Sku;

        [JsonProperty("taxable")]
        [JsonPropertyName("taxable")]
        public bool Taxable;

        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string Title;

        [JsonProperty("total_discount")]
        [JsonPropertyName("total_discount")]
        public string TotalDiscount;

        [JsonProperty("total_discount_set")]
        [JsonPropertyName("total_discount_set")]
        public TotalDiscountSet TotalDiscountSet;

        [JsonProperty("variant_id")]
        [JsonPropertyName("variant_id")]
        public int VariantId;

        [JsonProperty("variant_inventory_management")]
        [JsonPropertyName("variant_inventory_management")]
        public string VariantInventoryManagement;

        [JsonProperty("variant_title")]
        [JsonPropertyName("variant_title")]
        public object VariantTitle;

        [JsonProperty("vendor")]
        [JsonPropertyName("vendor")]
        public object Vendor;

        [JsonProperty("tax_lines")]
        [JsonPropertyName("tax_lines")]
        public List<object> TaxLines;

        [JsonProperty("duties")]
        [JsonPropertyName("duties")]
        public List<object> Duties;

        [JsonProperty("discount_allocations")]
        [JsonPropertyName("discount_allocations")]
        public List<object> DiscountAllocations;
    }

    public class PresentmentMoney
    {
        [JsonProperty("amount")]
        [JsonPropertyName("amount")]
        public string Amount;

        [JsonProperty("currency_code")]
        [JsonPropertyName("currency_code")]
        public string CurrencyCode;
    }

    public class PriceSet
    {
        [JsonProperty("shop_money")]
        [JsonPropertyName("shop_money")]
        public ShopMoney ShopMoney;

        [JsonProperty("presentment_money")]
        [JsonPropertyName("presentment_money")]
        public PresentmentMoney PresentmentMoney;
    }

    public class ShopifyOrder
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public long Id;

        [JsonProperty("admin_graphql_api_id")]
        [JsonPropertyName("admin_graphql_api_id")]
        public string AdminGraphqlApiId;

        [JsonProperty("app_id")]
        [JsonPropertyName("app_id")]
        public object AppId;

        [JsonProperty("browser_ip")]
        [JsonPropertyName("browser_ip")]
        public object BrowserIp;

        [JsonProperty("buyer_accepts_marketing")]
        [JsonPropertyName("buyer_accepts_marketing")]
        public bool BuyerAcceptsMarketing;

        [JsonProperty("cancel_reason")]
        [JsonPropertyName("cancel_reason")]
        public string CancelReason;

        [JsonProperty("cancelled_at")]
        [JsonPropertyName("cancelled_at")]
        public DateTime CancelledAt;

        [JsonProperty("cart_token")]
        [JsonPropertyName("cart_token")]
        public object CartToken;

        [JsonProperty("checkout_id")]
        [JsonPropertyName("checkout_id")]
        public object CheckoutId;

        [JsonProperty("checkout_token")]
        [JsonPropertyName("checkout_token")]
        public object CheckoutToken;

        [JsonProperty("client_details")]
        [JsonPropertyName("client_details")]
        public object ClientDetails;

        [JsonProperty("closed_at")]
        [JsonPropertyName("closed_at")]
        public object ClosedAt;

        [JsonProperty("confirmed")]
        [JsonPropertyName("confirmed")]
        public bool Confirmed;

        [JsonProperty("contact_email")]
        [JsonPropertyName("contact_email")]
        public string ContactEmail;

        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt;

        [JsonProperty("currency")]
        [JsonPropertyName("currency")]
        public string Currency;

        [JsonProperty("current_subtotal_price")]
        [JsonPropertyName("current_subtotal_price")]
        public string CurrentSubtotalPrice;

        [JsonProperty("current_subtotal_price_set")]
        [JsonPropertyName("current_subtotal_price_set")]
        public CurrentSubtotalPriceSet CurrentSubtotalPriceSet;

        [JsonProperty("current_total_additional_fees_set")]
        [JsonPropertyName("current_total_additional_fees_set")]
        public object CurrentTotalAdditionalFeesSet;

        [JsonProperty("current_total_discounts")]
        [JsonPropertyName("current_total_discounts")]
        public string CurrentTotalDiscounts;

        [JsonProperty("current_total_discounts_set")]
        [JsonPropertyName("current_total_discounts_set")]
        public CurrentTotalDiscountsSet CurrentTotalDiscountsSet;

        [JsonProperty("current_total_duties_set")]
        [JsonPropertyName("current_total_duties_set")]
        public object CurrentTotalDutiesSet;

        [JsonProperty("current_total_price")]
        [JsonPropertyName("current_total_price")]
        public string CurrentTotalPrice;

        [JsonProperty("current_total_price_set")]
        [JsonPropertyName("current_total_price_set")]
        public CurrentTotalPriceSet CurrentTotalPriceSet;

        [JsonProperty("current_total_tax")]
        [JsonPropertyName("current_total_tax")]
        public string CurrentTotalTax;

        [JsonProperty("current_total_tax_set")]
        [JsonPropertyName("current_total_tax_set")]
        public CurrentTotalTaxSet CurrentTotalTaxSet;

        [JsonProperty("customer_locale")]
        [JsonPropertyName("customer_locale")]
        public string CustomerLocale;

        [JsonProperty("device_id")]
        [JsonPropertyName("device_id")]
        public object DeviceId;

        [JsonProperty("discount_codes")]
        [JsonPropertyName("discount_codes")]
        public List<object> DiscountCodes;

        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email;

        [JsonProperty("estimated_taxes")]
        [JsonPropertyName("estimated_taxes")]
        public bool EstimatedTaxes;

        [JsonProperty("financial_status")]
        [JsonPropertyName("financial_status")]
        public string FinancialStatus;

        [JsonProperty("fulfillment_status")]
        [JsonPropertyName("fulfillment_status")]
        public string FulfillmentStatus;

        [JsonProperty("landing_site")]
        [JsonPropertyName("landing_site")]
        public object LandingSite;

        [JsonProperty("landing_site_ref")]
        [JsonPropertyName("landing_site_ref")]
        public object LandingSiteRef;

        [JsonProperty("location_id")]
        [JsonPropertyName("location_id")]
        public object LocationId;

        [JsonProperty("merchant_of_record_app_id")]
        [JsonPropertyName("merchant_of_record_app_id")]
        public object MerchantOfRecordAppId;

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name;

        [JsonProperty("note")]
        [JsonPropertyName("note")]
        public object Note;

        [JsonProperty("note_attributes")]
        [JsonPropertyName("note_attributes")]
        public List<object> NoteAttributes;

        [JsonProperty("number")]
        [JsonPropertyName("number")]
        public int Number;

        [JsonProperty("order_number")]
        [JsonPropertyName("order_number")]
        public int OrderNumber;

        [JsonProperty("order_status_url")]
        [JsonPropertyName("order_status_url")]
        public string OrderStatusUrl;

        [JsonProperty("original_total_additional_fees_set")]
        [JsonPropertyName("original_total_additional_fees_set")]
        public object OriginalTotalAdditionalFeesSet;

        [JsonProperty("original_total_duties_set")]
        [JsonPropertyName("original_total_duties_set")]
        public object OriginalTotalDutiesSet;

        [JsonProperty("payment_gateway_names")]
        [JsonPropertyName("payment_gateway_names")]
        public List<string> PaymentGatewayNames;

        [JsonProperty("phone")]
        [JsonPropertyName("phone")]
        public object Phone;

        [JsonProperty("presentment_currency")]
        [JsonPropertyName("presentment_currency")]
        public string PresentmentCurrency;

        [JsonProperty("processed_at")]
        [JsonPropertyName("processed_at")]
        public object ProcessedAt;

        [JsonProperty("reference")]
        [JsonPropertyName("reference")]
        public object Reference;

        [JsonProperty("referring_site")]
        [JsonPropertyName("referring_site")]
        public object ReferringSite;

        [JsonProperty("source_identifier")]
        [JsonPropertyName("source_identifier")]
        public object SourceIdentifier;

        [JsonProperty("source_name")]
        [JsonPropertyName("source_name")]
        public string SourceName;

        [JsonProperty("source_url")]
        [JsonPropertyName("source_url")]
        public object SourceUrl;

        [JsonProperty("subtotal_price")]
        [JsonPropertyName("subtotal_price")]
        public string SubtotalPrice;

        [JsonProperty("subtotal_price_set")]
        [JsonPropertyName("subtotal_price_set")]
        public SubtotalPriceSet SubtotalPriceSet;

        [JsonProperty("tags")]
        [JsonPropertyName("tags")]
        public string Tags;

        [JsonProperty("tax_lines")]
        [JsonPropertyName("tax_lines")]
        public List<object> TaxLines;

        [JsonProperty("taxes_included")]
        [JsonPropertyName("taxes_included")]
        public bool TaxesIncluded;

        [JsonProperty("test")]
        [JsonPropertyName("test")]
        public bool Test;

        [JsonProperty("token")]
        [JsonPropertyName("token")]
        public string Token;

        [JsonProperty("total_discounts")]
        [JsonPropertyName("total_discounts")]
        public string TotalDiscounts;

        [JsonProperty("total_discounts_set")]
        [JsonPropertyName("total_discounts_set")]
        public TotalDiscountsSet TotalDiscountsSet;

        [JsonProperty("total_line_items_price")]
        [JsonPropertyName("total_line_items_price")]
        public string TotalLineItemsPrice;

        [JsonProperty("total_line_items_price_set")]
        [JsonPropertyName("total_line_items_price_set")]
        public TotalLineItemsPriceSet TotalLineItemsPriceSet;

        [JsonProperty("total_outstanding")]
        [JsonPropertyName("total_outstanding")]
        public string TotalOutstanding;

        [JsonProperty("total_price")]
        [JsonPropertyName("total_price")]
        public string TotalPrice;

        [JsonProperty("total_price_set")]
        [JsonPropertyName("total_price_set")]
        public TotalPriceSet TotalPriceSet;

        [JsonProperty("total_shipping_price_set")]
        [JsonPropertyName("total_shipping_price_set")]
        public TotalShippingPriceSet TotalShippingPriceSet;

        [JsonProperty("total_tax")]
        [JsonPropertyName("total_tax")]
        public string TotalTax;

        [JsonProperty("total_tax_set")]
        [JsonPropertyName("total_tax_set")]
        public TotalTaxSet TotalTaxSet;

        [JsonProperty("total_tip_received")]
        [JsonPropertyName("total_tip_received")]
        public string TotalTipReceived;

        [JsonProperty("total_weight")]
        [JsonPropertyName("total_weight")]
        public int TotalWeight;

        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt;

        [JsonProperty("user_id")]
        [JsonPropertyName("user_id")]
        public object UserId;

        [JsonProperty("billing_address")]
        [JsonPropertyName("billing_address")]
        public BillingAddress BillingAddress;

        [JsonProperty("customer")]
        [JsonPropertyName("customer")]
        public Customer Customer;

        [JsonProperty("discount_applications")]
        [JsonPropertyName("discount_applications")]
        public List<object> DiscountApplications;

        [JsonProperty("fulfillments")]
        [JsonPropertyName("fulfillments")]
        public List<object> Fulfillments;

        [JsonProperty("line_items")]
        [JsonPropertyName("line_items")]
        public List<LineItem> LineItems;

        [JsonProperty("payment_terms")]
        [JsonPropertyName("payment_terms")]
        public object PaymentTerms;

        [JsonProperty("refunds")]
        [JsonPropertyName("refunds")]
        public List<object> Refunds;

        [JsonProperty("shipping_address")]
        [JsonPropertyName("shipping_address")]
        public ShippingAddress ShippingAddress;

        [JsonProperty("shipping_lines")]
        [JsonPropertyName("shipping_lines")]
        public List<ShippingLine> ShippingLines;
    }

    public class ShippingAddress
    {
        [JsonProperty("first_name")]
        [JsonPropertyName("first_name")]
        public string FirstName;

        [JsonProperty("address1")]
        [JsonPropertyName("address1")]
        public string Address1;

        [JsonProperty("phone")]
        [JsonPropertyName("phone")]
        public string Phone;

        [JsonProperty("city")]
        [JsonPropertyName("city")]
        public string City;

        [JsonProperty("zip")]
        [JsonPropertyName("zip")]
        public string Zip;

        [JsonProperty("province")]
        [JsonPropertyName("province")]
        public string Province;

        [JsonProperty("country")]
        [JsonPropertyName("country")]
        public string Country;

        [JsonProperty("last_name")]
        [JsonPropertyName("last_name")]
        public string LastName;

        [JsonProperty("address2")]
        [JsonPropertyName("address2")]
        public object Address2;

        [JsonProperty("company")]
        [JsonPropertyName("company")]
        public string Company;

        [JsonProperty("latitude")]
        [JsonPropertyName("latitude")]
        public object Latitude;

        [JsonProperty("longitude")]
        [JsonPropertyName("longitude")]
        public object Longitude;

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name;

        [JsonProperty("country_code")]
        [JsonPropertyName("country_code")]
        public string CountryCode;

        [JsonProperty("province_code")]
        [JsonPropertyName("province_code")]
        public string ProvinceCode;
    }

    public class ShippingLine
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public long Id;

        [JsonProperty("carrier_identifier")]
        [JsonPropertyName("carrier_identifier")]
        public object CarrierIdentifier;

        [JsonProperty("code")]
        [JsonPropertyName("code")]
        public object Code;

        [JsonProperty("delivery_category")]
        [JsonPropertyName("delivery_category")]
        public object DeliveryCategory;

        [JsonProperty("discounted_price")]
        [JsonPropertyName("discounted_price")]
        public string DiscountedPrice;

        [JsonProperty("discounted_price_set")]
        [JsonPropertyName("discounted_price_set")]
        public DiscountedPriceSet DiscountedPriceSet;

        [JsonProperty("phone")]
        [JsonPropertyName("phone")]
        public object Phone;

        [JsonProperty("price")]
        [JsonPropertyName("price")]
        public string Price;

        [JsonProperty("price_set")]
        [JsonPropertyName("price_set")]
        public PriceSet PriceSet;

        [JsonProperty("requested_fulfillment_service_id")]
        [JsonPropertyName("requested_fulfillment_service_id")]
        public object RequestedFulfillmentServiceId;

        [JsonProperty("source")]
        [JsonPropertyName("source")]
        public string Source;

        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string Title;

        [JsonProperty("tax_lines")]
        [JsonPropertyName("tax_lines")]
        public List<object> TaxLines;

        [JsonProperty("discount_allocations")]
        [JsonPropertyName("discount_allocations")]
        public List<object> DiscountAllocations;
    }

    public class ShopMoney
    {
        [JsonProperty("amount")]
        [JsonPropertyName("amount")]
        public string Amount;

        [JsonProperty("currency_code")]
        [JsonPropertyName("currency_code")]
        public string CurrencyCode;
    }

    public class SubtotalPriceSet
    {
        [JsonProperty("shop_money")]
        [JsonPropertyName("shop_money")]
        public ShopMoney ShopMoney;

        [JsonProperty("presentment_money")]
        [JsonPropertyName("presentment_money")]
        public PresentmentMoney PresentmentMoney;
    }

    public class TotalDiscountSet
    {
        [JsonProperty("shop_money")]
        [JsonPropertyName("shop_money")]
        public ShopMoney ShopMoney;

        [JsonProperty("presentment_money")]
        [JsonPropertyName("presentment_money")]
        public PresentmentMoney PresentmentMoney;
    }

    public class TotalDiscountsSet
    {
        [JsonProperty("shop_money")]
        [JsonPropertyName("shop_money")]
        public ShopMoney ShopMoney;

        [JsonProperty("presentment_money")]
        [JsonPropertyName("presentment_money")]
        public PresentmentMoney PresentmentMoney;
    }

    public class TotalLineItemsPriceSet
    {
        [JsonProperty("shop_money")]
        [JsonPropertyName("shop_money")]
        public ShopMoney ShopMoney;

        [JsonProperty("presentment_money")]
        [JsonPropertyName("presentment_money")]
        public PresentmentMoney PresentmentMoney;
    }

    public class TotalPriceSet
    {
        [JsonProperty("shop_money")]
        [JsonPropertyName("shop_money")]
        public ShopMoney ShopMoney;

        [JsonProperty("presentment_money")]
        [JsonPropertyName("presentment_money")]
        public PresentmentMoney PresentmentMoney;
    }

    public class TotalShippingPriceSet
    {
        [JsonProperty("shop_money")]
        [JsonPropertyName("shop_money")]
        public ShopMoney ShopMoney;

        [JsonProperty("presentment_money")]
        [JsonPropertyName("presentment_money")]
        public PresentmentMoney PresentmentMoney;
    }

    public class TotalTaxSet
    {
        [JsonProperty("shop_money")]
        [JsonPropertyName("shop_money")]
        public ShopMoney ShopMoney;

        [JsonProperty("presentment_money")]
        [JsonPropertyName("presentment_money")]
        public PresentmentMoney PresentmentMoney;
    }


}
