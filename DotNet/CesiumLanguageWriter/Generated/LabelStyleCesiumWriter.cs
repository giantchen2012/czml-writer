// This file was generated automatically by GenerateFromSchema.  Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer

using CesiumLanguageWriter.Advanced;
using System;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <code>LabelStyle</code> to a <see cref="CesiumOutputStream" />.  A <code>LabelStyle</code> the style of a label.
    /// </summary>
    public class LabelStyleCesiumWriter : CesiumPropertyWriter<LabelStyleCesiumWriter>
    {
        /// <summary>
        /// The name of the <code>labelStyle</code> property.
        /// </summary>
        public const string LabelStylePropertyName = "labelStyle";

        /// <summary>
        /// The name of the <code>reference</code> property.
        /// </summary>
        public const string ReferencePropertyName = "reference";

        private readonly Lazy<ICesiumValuePropertyWriter<CesiumLabelStyle>> m_asLabelStyle;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public LabelStyleCesiumWriter(string propertyName)
            : base(propertyName)
        {
            m_asLabelStyle = new Lazy<ICesiumValuePropertyWriter<CesiumLabelStyle>>(CreateLabelStyleAdaptor, false);
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param> 
        protected LabelStyleCesiumWriter(LabelStyleCesiumWriter existingInstance)
            : base(existingInstance)
        {
            m_asLabelStyle = new Lazy<ICesiumValuePropertyWriter<CesiumLabelStyle>>(CreateLabelStyleAdaptor, false);
        }

        /// <inheritdoc />
        public override LabelStyleCesiumWriter Clone()
        {
            return new LabelStyleCesiumWriter(this);
        }

        /// <summary>
        /// Writes the <code>labelStyle</code> property.  The <code>labelStyle</code> property specifies the label style.  Valid values are "FILL", "OUTLINE", and "FILL_AND_OUTLINE".
        /// </summary>
        /// <param name="value">The label style.</param>
        public void WriteLabelStyle(CesiumLabelStyle value)
        {
            const string PropertyName = LabelStylePropertyName;
            if (IsInterval)
                Output.WritePropertyName(PropertyName);
            Output.WriteValue(CesiumFormattingHelper.LabelStyleToString(value));
        }

        /// <summary>
        /// Writes the <code>reference</code> property.  The <code>reference</code> property specifies a reference property.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteReference(Reference value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the <code>reference</code> property.  The <code>reference</code> property specifies a reference property.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteReference(string value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the <code>reference</code> property.  The <code>reference</code> property specifies a reference property.
        /// </summary>
        /// <param name="id">The earliest date of the interval.</param>
        /// <param name="propertyName">The latest date of the interval.</param>
        public void WriteReference(string id, string propertyName)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, id, propertyName);
        }

        /// <summary>
        /// Writes the <code>reference</code> property.  The <code>reference</code> property specifies a reference property.
        /// </summary>
        /// <param name="id">The earliest date of the interval.</param>
        /// <param name="propertyNames">The latest date of the interval.</param>
        public void WriteReference(string id, string[] propertyNames)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, id, propertyNames);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumValuePropertyWriter{T}" /> to write a value in <code>LabelStyle</code> format.  Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close" /> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public ICesiumValuePropertyWriter<CesiumLabelStyle> AsLabelStyle()
        {
            return m_asLabelStyle.Value;
        }

        private ICesiumValuePropertyWriter<CesiumLabelStyle> CreateLabelStyleAdaptor()
        {
            return new CesiumWriterAdaptor<LabelStyleCesiumWriter, CesiumLabelStyle>(
                this, (me, value) => me.WriteLabelStyle(value));
        }

    }
}
