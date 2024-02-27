namespace WiiAppSpotifyClone1
{
    partial class SongPlayer
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bDD_SpotifyMusicDataSet = new WiiAppSpotifyClone1.BDD_SpotifyMusicDataSet();
            this.bDDSpotifyMusicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDD_SpotifyMusicDataSet1 = new WiiAppSpotifyClone1.BDD_SpotifyMusicDataSet1();
            this.tBLSONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_SONGTableAdapter = new WiiAppSpotifyClone1.BDD_SpotifyMusicDataSet1TableAdapters.TBL_SONGTableAdapter();
            this.iDSONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sONGNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sONGPATHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLAYSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDD_SpotifyMusicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDSpotifyMusicDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDD_SpotifyMusicDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSONGDataGridViewTextBoxColumn,
            this.sONGNAMEDataGridViewTextBoxColumn,
            this.sONGPATHDataGridViewTextBoxColumn,
            this.pLAYSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLSONGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(737, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // bDD_SpotifyMusicDataSet
            // 
            this.bDD_SpotifyMusicDataSet.DataSetName = "BDD_SpotifyMusicDataSet";
            this.bDD_SpotifyMusicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDDSpotifyMusicDataSetBindingSource
            // 
            this.bDDSpotifyMusicDataSetBindingSource.DataSource = this.bDD_SpotifyMusicDataSet;
            this.bDDSpotifyMusicDataSetBindingSource.Position = 0;
            // 
            // bDD_SpotifyMusicDataSet1
            // 
            this.bDD_SpotifyMusicDataSet1.DataSetName = "BDD_SpotifyMusicDataSet1";
            this.bDD_SpotifyMusicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLSONGBindingSource
            // 
            this.tBLSONGBindingSource.DataMember = "TBL_SONG";
            this.tBLSONGBindingSource.DataSource = this.bDD_SpotifyMusicDataSet1;
            // 
            // tBL_SONGTableAdapter
            // 
            this.tBL_SONGTableAdapter.ClearBeforeFill = true;
            // 
            // iDSONGDataGridViewTextBoxColumn
            // 
            this.iDSONGDataGridViewTextBoxColumn.DataPropertyName = "ID_SONG";
            this.iDSONGDataGridViewTextBoxColumn.HeaderText = "ID_SONG";
            this.iDSONGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDSONGDataGridViewTextBoxColumn.Name = "iDSONGDataGridViewTextBoxColumn";
            this.iDSONGDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSONGDataGridViewTextBoxColumn.Width = 125;
            // 
            // sONGNAMEDataGridViewTextBoxColumn
            // 
            this.sONGNAMEDataGridViewTextBoxColumn.DataPropertyName = "SONG_NAME";
            this.sONGNAMEDataGridViewTextBoxColumn.HeaderText = "SONG_NAME";
            this.sONGNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sONGNAMEDataGridViewTextBoxColumn.Name = "sONGNAMEDataGridViewTextBoxColumn";
            this.sONGNAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // sONGPATHDataGridViewTextBoxColumn
            // 
            this.sONGPATHDataGridViewTextBoxColumn.DataPropertyName = "SONG_PATH";
            this.sONGPATHDataGridViewTextBoxColumn.HeaderText = "SONG_PATH";
            this.sONGPATHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sONGPATHDataGridViewTextBoxColumn.Name = "sONGPATHDataGridViewTextBoxColumn";
            this.sONGPATHDataGridViewTextBoxColumn.Width = 125;
            // 
            // pLAYSDataGridViewTextBoxColumn
            // 
            this.pLAYSDataGridViewTextBoxColumn.DataPropertyName = "PLAYS";
            this.pLAYSDataGridViewTextBoxColumn.HeaderText = "PLAYS";
            this.pLAYSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pLAYSDataGridViewTextBoxColumn.Name = "pLAYSDataGridViewTextBoxColumn";
            this.pLAYSDataGridViewTextBoxColumn.Width = 125;
            // 
            // SongPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SongPlayer";
            this.Text = "SongPlayer";
            this.Load += new System.EventHandler(this.SongPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDD_SpotifyMusicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDSpotifyMusicDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDD_SpotifyMusicDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSONGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bDDSpotifyMusicDataSetBindingSource;
        private BDD_SpotifyMusicDataSet bDD_SpotifyMusicDataSet;
        private BDD_SpotifyMusicDataSet1 bDD_SpotifyMusicDataSet1;
        private System.Windows.Forms.BindingSource tBLSONGBindingSource;
        private BDD_SpotifyMusicDataSet1TableAdapters.TBL_SONGTableAdapter tBL_SONGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sONGNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sONGPATHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLAYSDataGridViewTextBoxColumn;
    }
}