#region Imports

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ReaLTaiizor.Util;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#endregion

namespace ReaLTaiizor.Controls
{
    #region AloneComboBox

    public class AloneComboBoxCustom : ComboBox
    {
        private Graphics G;
        private Rectangle Rect;
        private bool _EnabledCalc;
        private Color _backgroundColor = Color.White;
        private Color _borderColor = AloneLibrary.ColorFromHex("#D0D5D9");
        private Color _selectedItemColor = AloneLibrary.ColorFromHex("#78B7E6");
        private int _itemHeight = 20;
        private ContentAlignment _textAlign = ContentAlignment.MiddleLeft;
        private Color _comboBoxForeColor = SystemColors.ControlText; // Nuevo campo para el color del texto en el ComboBox

        public new bool Enabled
        {
            get => _EnabledCalc;
            set
            {
                _EnabledCalc = value;
                Invalidate();
            }
        }

        [DisplayName("Enabled")]
        public bool EnabledCalc
        {
            get => _EnabledCalc;
            set
            {
                base.Enabled = value;
                _EnabledCalc = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Color del fondo del ComboBox")]
        public Color BackgroundColor
        {
            get => _backgroundColor;
            set
            {
                _backgroundColor = value;
                Invalidate(); // Invalida el control para redibujar con el nuevo color de fondo
            }
        }

        [Category("Appearance")]
        [Description("Color del borde del ComboBox")]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                _borderColor = value;
                Invalidate(); // Invalida el control para redibujar con el nuevo color de borde
            }
        }

        [Category("Appearance")]
        [Description("Color del ítem seleccionado en el ComboBox")]
        public Color SelectedItemColor
        {
            get => _selectedItemColor;
            set
            {
                _selectedItemColor = value;
                Invalidate(); // Invalida el control para redibujar con el nuevo color del ítem seleccionado
            }
        }

        [Category("Appearance")]
        [Description("Altura de los ítems en el ComboBox")]
        public int ItemHeightCustom
        {
            get => _itemHeight;
            set
            {
                _itemHeight = value;
                base.ItemHeight = value;
                Invalidate(); // Invalida el control para redibujar con la nueva altura de ítem
            }
        }

        [Category("Appearance")]
        [Description("Alineación del texto en el ComboBox")]
        public ContentAlignment TextAlign
        {
            get => _textAlign;
            set
            {
                _textAlign = value;
                Invalidate(); // Invalida el control para redibujar con la nueva alineación del texto
            }
        }

        [Category("Appearance")]
        [Description("Color del texto en el ComboBox")]
        public Color ComboBoxForeColor
        {
            get => _comboBoxForeColor;
            set
            {
                _comboBoxForeColor = value;
                Invalidate(); // Invalida el control para redibujar con el nuevo color de texto
            }
        }

        public AloneComboBoxCustom()
        {
            DoubleBuffered = true;
            base.DropDownStyle = ComboBoxStyle.DropDownList;
            Cursor = Cursors.Hand;
            Enabled = true;
            base.DrawMode = DrawMode.OwnerDrawFixed;
            base.ItemHeight = _itemHeight;
            Size = new Size(64, 26); // Ajusta el tamaño inicial según tus necesidades
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            base.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;
            G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            // Dibuja el fondo con bordes redondeados
            using (GraphicsPath backgroundPath = AloneLibrary.RoundRect(AloneLibrary.FullRectangle(base.Size, true), 6, AloneLibrary.RoundingStyle.All))
            {
                using (SolidBrush backgroundBrush = new SolidBrush(BackgroundColor))
                {
                    G.FillPath(backgroundBrush, backgroundPath);
                }
            }

            // Dibuja el borde con bordes redondeados
            using (GraphicsPath borderPath = AloneLibrary.RoundRect(AloneLibrary.FullRectangle(base.Size, true), 6, AloneLibrary.RoundingStyle.All))
            {
                using (Pen borderPen = new Pen(BorderColor))
                {
                    G.DrawPath(borderPen, borderPath);
                }
            }

            // Dibuja el texto seleccionado en el ComboBox
            if (base.Items.Count > 0)
            {
                using (Font font = new Font("Segoe UI", 9f))
                {
                    using (SolidBrush solidBrush = new SolidBrush(ComboBoxForeColor))
                    {
                        string text = base.GetItemText(RuntimeHelpers.GetObjectValue(base.Items[SelectedIndex >= 0 ? SelectedIndex : 0]));
                        Rectangle textRect = AlignText(text, font, base.ClientRectangle);
                        G.DrawString(text, font, solidBrush, textRect);
                    }
                }
            }
        }

        private Rectangle AlignText(string text, Font font, Rectangle rect)
        {
            Size textSize = TextRenderer.MeasureText(text, font);
            int x = rect.X;
            int y = rect.Y;

            switch (TextAlign)
            {
                case ContentAlignment.TopLeft:
                    x = rect.Left + 7;
                    y = rect.Top + 4;
                    break;
                case ContentAlignment.TopCenter:
                    x = rect.Left + (rect.Width - textSize.Width) / 2;
                    y = rect.Top + 4;
                    break;
                case ContentAlignment.TopRight:
                    x = rect.Right - textSize.Width - 7;
                    y = rect.Top + 4;
                    break;
                case ContentAlignment.MiddleLeft:
                    x = rect.Left + 7;
                    y = rect.Top + (rect.Height - textSize.Height) / 2;
                    break;
                case ContentAlignment.MiddleCenter:
                    x = rect.Left + (rect.Width - textSize.Width) / 2;
                    y = rect.Top + (rect.Height - textSize.Height) / 2;
                    break;
                case ContentAlignment.MiddleRight:
                    x = rect.Right - textSize.Width - 7;
                    y = rect.Top + (rect.Height - textSize.Height) / 2;
                    break;
                case ContentAlignment.BottomLeft:
                    x = rect.Left + 7;
                    y = rect.Bottom - textSize.Height - 4;
                    break;
                case ContentAlignment.BottomCenter:
                    x = rect.Left + (rect.Width - textSize.Width) / 2;
                    y = rect.Bottom - textSize.Height - 4;
                    break;
                case ContentAlignment.BottomRight:
                    x = rect.Right - textSize.Width - 7;
                    y = rect.Bottom - textSize.Height - 4;
                    break;
            }

            return new Rectangle(x, y, textSize.Width, textSize.Height);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;
            G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            bool enabled = Enabled;
            checked
            {
                if (enabled)
                {
                    e.DrawBackground();
                    Rect = e.Bounds;
                    try
                    {
                        using (Font font = new Font("Segoe UI", 9f))
                        {
                            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
                            using (SolidBrush brush = new SolidBrush(isSelected ? SelectedItemColor : BackgroundColor))
                            {
                                G.FillRectangle(brush, Rect);
                            }

                            using (SolidBrush textBrush = new SolidBrush(ComboBoxForeColor))
                            {
                                string text = base.GetItemText(RuntimeHelpers.GetObjectValue(base.Items[e.Index]));
                                Rectangle textRect = AlignText(text, font, Rect);
                                G.DrawString(text, font, isSelected ? Brushes.White : textBrush, textRect);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        // Maneja excepciones aquí si es necesario
                    }
                }
            }
        }

        protected override void OnSelectedItemChanged(EventArgs e)
        {
            base.OnSelectedItemChanged(e);
            Invalidate();
        }
    }

    #endregion
}
