namespace Generar_Licencias
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnGenerarArchivo = new DevExpress.XtraEditors.SimpleButton();
            this.TxtUniqueID1 = new DevExpress.XtraEditors.TextEdit();
            this.BtnValidarArchivo = new DevExpress.XtraEditors.SimpleButton();
            this.TxtSistema = new DevExpress.XtraEditors.TextEdit();
            this.TxtEmpresa = new DevExpress.XtraEditors.TextEdit();
            this.DatVigencia = new DevExpress.XtraEditors.DateEdit();
            this.OfdArchivo = new System.Windows.Forms.OpenFileDialog();
            this.TxtArchivo = new DevExpress.XtraEditors.TextEdit();
            this.BtnSeleccionarArchivo = new DevExpress.XtraEditors.SimpleButton();
            this.TxtUniqueID2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUniqueID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSistema.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatVigencia.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatVigencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtArchivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUniqueID2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGenerarArchivo
            // 
            this.BtnGenerarArchivo.Location = new System.Drawing.Point(217, 259);
            this.BtnGenerarArchivo.Name = "BtnGenerarArchivo";
            this.BtnGenerarArchivo.Size = new System.Drawing.Size(136, 21);
            this.BtnGenerarArchivo.TabIndex = 0;
            this.BtnGenerarArchivo.Text = "Generar Archivo";
            this.BtnGenerarArchivo.Click += new System.EventHandler(this.BtnGenerarArchivo_Click);
            // 
            // TxtUniqueID1
            // 
            this.TxtUniqueID1.Location = new System.Drawing.Point(75, 31);
            this.TxtUniqueID1.Name = "TxtUniqueID1";
            this.TxtUniqueID1.Size = new System.Drawing.Size(278, 20);
            this.TxtUniqueID1.TabIndex = 1;
            // 
            // BtnValidarArchivo
            // 
            this.BtnValidarArchivo.Location = new System.Drawing.Point(75, 83);
            this.BtnValidarArchivo.Name = "BtnValidarArchivo";
            this.BtnValidarArchivo.Size = new System.Drawing.Size(278, 28);
            this.BtnValidarArchivo.TabIndex = 2;
            this.BtnValidarArchivo.Text = "Validar archivo de licencia";
            this.BtnValidarArchivo.Click += new System.EventHandler(this.BtnValidarArchivo_Click);
            // 
            // TxtSistema
            // 
            this.TxtSistema.Location = new System.Drawing.Point(75, 234);
            this.TxtSistema.Name = "TxtSistema";
            this.TxtSistema.Size = new System.Drawing.Size(136, 20);
            this.TxtSistema.TabIndex = 3;
            // 
            // TxtEmpresa
            // 
            this.TxtEmpresa.Location = new System.Drawing.Point(75, 208);
            this.TxtEmpresa.Name = "TxtEmpresa";
            this.TxtEmpresa.Size = new System.Drawing.Size(136, 20);
            this.TxtEmpresa.TabIndex = 4;
            // 
            // DatVigencia
            // 
            this.DatVigencia.EditValue = "";
            this.DatVigencia.Location = new System.Drawing.Point(75, 260);
            this.DatVigencia.Name = "DatVigencia";
            this.DatVigencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DatVigencia.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DatVigencia.Size = new System.Drawing.Size(136, 20);
            this.DatVigencia.TabIndex = 5;
            // 
            // OfdArchivo
            // 
            this.OfdArchivo.FileName = "openFileDialog1";
            // 
            // TxtArchivo
            // 
            this.TxtArchivo.Location = new System.Drawing.Point(75, 57);
            this.TxtArchivo.Name = "TxtArchivo";
            this.TxtArchivo.Size = new System.Drawing.Size(176, 20);
            this.TxtArchivo.TabIndex = 6;
            // 
            // BtnSeleccionarArchivo
            // 
            this.BtnSeleccionarArchivo.Location = new System.Drawing.Point(257, 56);
            this.BtnSeleccionarArchivo.Name = "BtnSeleccionarArchivo";
            this.BtnSeleccionarArchivo.Size = new System.Drawing.Size(96, 21);
            this.BtnSeleccionarArchivo.TabIndex = 7;
            this.BtnSeleccionarArchivo.Text = "Seleccionar";
            this.BtnSeleccionarArchivo.Click += new System.EventHandler(this.BtnSeleccionarArchivo_Click);
            // 
            // TxtUniqueID2
            // 
            this.TxtUniqueID2.Location = new System.Drawing.Point(75, 182);
            this.TxtUniqueID2.Name = "TxtUniqueID2";
            this.TxtUniqueID2.Size = new System.Drawing.Size(278, 20);
            this.TxtUniqueID2.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "UniqueID:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Archivo:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 185);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "UniqueID:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(28, 211);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Sistema:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(24, 237);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 13);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Empresa:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(26, 263);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 13);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Vigencia:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 320);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TxtUniqueID2);
            this.Controls.Add(this.BtnSeleccionarArchivo);
            this.Controls.Add(this.TxtArchivo);
            this.Controls.Add(this.DatVigencia);
            this.Controls.Add(this.TxtEmpresa);
            this.Controls.Add(this.TxtSistema);
            this.Controls.Add(this.BtnValidarArchivo);
            this.Controls.Add(this.TxtUniqueID1);
            this.Controls.Add(this.BtnGenerarArchivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generar Licencia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtUniqueID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSistema.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatVigencia.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatVigencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtArchivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUniqueID2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnGenerarArchivo;
        private DevExpress.XtraEditors.TextEdit TxtUniqueID1;
        private DevExpress.XtraEditors.SimpleButton BtnValidarArchivo;
        private DevExpress.XtraEditors.TextEdit TxtSistema;
        private DevExpress.XtraEditors.TextEdit TxtEmpresa;
        private DevExpress.XtraEditors.DateEdit DatVigencia;
        private System.Windows.Forms.OpenFileDialog OfdArchivo;
        private DevExpress.XtraEditors.TextEdit TxtArchivo;
        private DevExpress.XtraEditors.SimpleButton BtnSeleccionarArchivo;
        private DevExpress.XtraEditors.TextEdit TxtUniqueID2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;

    }
}

