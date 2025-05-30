// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(WebSlotSwapWithPreviewCancelledEventDataConverter))]
    public partial class WebSlotSwapWithPreviewCancelledEventData
    {
        internal static WebSlotSwapWithPreviewCancelledEventData DeserializeWebSlotSwapWithPreviewCancelledEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AppEventTypeDetail appEventTypeDetail = default;
            string name = default;
            string clientRequestId = default;
            string correlationRequestId = default;
            string requestId = default;
            string address = default;
            string verb = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appEventTypeDetail"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appEventTypeDetail = AppEventTypeDetail.DeserializeAppEventTypeDetail(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientRequestId"u8))
                {
                    clientRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationRequestId"u8))
                {
                    correlationRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("address"u8))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("verb"u8))
                {
                    verb = property.Value.GetString();
                    continue;
                }
            }
            return new WebSlotSwapWithPreviewCancelledEventData(
                appEventTypeDetail,
                name,
                clientRequestId,
                correlationRequestId,
                requestId,
                address,
                verb);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static WebSlotSwapWithPreviewCancelledEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeWebSlotSwapWithPreviewCancelledEventData(document.RootElement);
        }

        internal partial class WebSlotSwapWithPreviewCancelledEventDataConverter : JsonConverter<WebSlotSwapWithPreviewCancelledEventData>
        {
            public override void Write(Utf8JsonWriter writer, WebSlotSwapWithPreviewCancelledEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override WebSlotSwapWithPreviewCancelledEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeWebSlotSwapWithPreviewCancelledEventData(document.RootElement);
            }
        }
    }
}
