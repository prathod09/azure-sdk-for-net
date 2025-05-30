// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    [PersistableModelProxy(typeof(UnknownDatasetStorageFormat))]
    public partial class DatasetStorageFormat : IUtf8JsonSerializable, IJsonModel<DatasetStorageFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DatasetStorageFormat>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DatasetStorageFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatasetStorageFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatasetStorageFormat)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(DatasetStorageFormatType);
            if (Optional.IsDefined(Serializer))
            {
                writer.WritePropertyName("serializer"u8);
                JsonSerializer.Serialize(writer, Serializer);
            }
            if (Optional.IsDefined(Deserializer))
            {
                writer.WritePropertyName("deserializer"u8);
                JsonSerializer.Serialize(writer, Deserializer);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
        }

        DatasetStorageFormat IJsonModel<DatasetStorageFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatasetStorageFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatasetStorageFormat)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDatasetStorageFormat(document.RootElement, options);
        }

        internal static DatasetStorageFormat DeserializeDatasetStorageFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AvroFormat": return DatasetAvroFormat.DeserializeDatasetAvroFormat(element, options);
                    case "JsonFormat": return DatasetJsonFormat.DeserializeDatasetJsonFormat(element, options);
                    case "OrcFormat": return DatasetOrcFormat.DeserializeDatasetOrcFormat(element, options);
                    case "ParquetFormat": return DatasetParquetFormat.DeserializeDatasetParquetFormat(element, options);
                    case "TextFormat": return DatasetTextFormat.DeserializeDatasetTextFormat(element, options);
                }
            }
            return UnknownDatasetStorageFormat.DeserializeUnknownDatasetStorageFormat(element, options);
        }

        BinaryData IPersistableModel<DatasetStorageFormat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatasetStorageFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DatasetStorageFormat)} does not support writing '{options.Format}' format.");
            }
        }

        DatasetStorageFormat IPersistableModel<DatasetStorageFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatasetStorageFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDatasetStorageFormat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DatasetStorageFormat)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DatasetStorageFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
