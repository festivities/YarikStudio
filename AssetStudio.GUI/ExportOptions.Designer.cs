using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AssetStudio.GUI
{
    partial class ExportOptions
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
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.OKbutton = new Button();
            this.Cancel = new Button();
            this.groupBox1 = new GroupBox();
            this.removeTexNameButton = new Button();
            this.addTexNameButton = new Button();
            this.texNameComboBox = new ComboBox();
            this.label10 = new Label();
            this.texTypeComboBox = new ComboBox();
            this.uvTypesComboBox = new ComboBox();
            this.uvEnabledCheckBox = new CheckBox();
            this.uvsComboBox = new ComboBox();
            this.canExportCheckBox = new CheckBox();
            this.label8 = new Label();
            this.canParseCheckBox = new CheckBox();
            this.typesComboBox = new ComboBox();
            this.label6 = new Label();
            this.minimalAssetMap = new CheckBox();
            this.assetGroupOptions = new ComboBox();
            this.label7 = new Label();
            this.openAfterExport = new CheckBox();
            this.restoreExtensionName = new CheckBox();
            this.key = new NumericUpDown();
            this.encrypted = new CheckBox();
            this.convertAudio = new CheckBox();
            this.panel1 = new Panel();
            this.tohdr = new RadioButton();
            this.totga = new RadioButton();
            this.tojpg = new RadioButton();
            this.topng = new RadioButton();
            this.tobmp = new RadioButton();
            this.converttexture = new CheckBox();
            this.collectAnimations = new CheckBox();
            this.groupBox2 = new GroupBox();
            this.exportMaterials = new CheckBox();
            this.exportBlendShape = new CheckBox();
            this.exportAnimations = new CheckBox();
            this.scaleFactor = new NumericUpDown();
            this.label5 = new Label();
            this.fbxFormat = new ComboBox();
            this.label4 = new Label();
            this.fbxVersion = new ComboBox();
            this.label3 = new Label();
            this.boneSize = new NumericUpDown();
            this.label2 = new Label();
            this.exportSkins = new CheckBox();
            this.label1 = new Label();
            this.filterPrecision = new NumericUpDown();
            this.castToBone = new CheckBox();
            this.exportAllNodes = new CheckBox();
            this.eulerFilter = new CheckBox();
            this.toolTip = new ToolTip(this.components);
            this.Reset = new Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.key).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.scaleFactor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.boneSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.filterPrecision).BeginInit();
            this.SuspendLayout();
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(549, 571);
            this.OKbutton.Margin = new Padding(5);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(101, 35);
            this.OKbutton.TabIndex = 6;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += this.OKbutton_Click;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(658, 571);
            this.Cancel.Margin = new Padding(5);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(101, 35);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += this.Cancel_Click;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.removeTexNameButton);
            this.groupBox1.Controls.Add(this.addTexNameButton);
            this.groupBox1.Controls.Add(this.texNameComboBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.texTypeComboBox);
            this.groupBox1.Controls.Add(this.uvTypesComboBox);
            this.groupBox1.Controls.Add(this.uvEnabledCheckBox);
            this.groupBox1.Controls.Add(this.uvsComboBox);
            this.groupBox1.Controls.Add(this.canExportCheckBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.canParseCheckBox);
            this.groupBox1.Controls.Add(this.typesComboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.minimalAssetMap);
            this.groupBox1.Controls.Add(this.assetGroupOptions);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.openAfterExport);
            this.groupBox1.Controls.Add(this.restoreExtensionName);
            this.groupBox1.Controls.Add(this.key);
            this.groupBox1.Controls.Add(this.encrypted);
            this.groupBox1.Controls.Add(this.convertAudio);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.converttexture);
            this.groupBox1.Location = new System.Drawing.Point(16, 20);
            this.groupBox1.Margin = new Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(366, 577);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export";
            // 
            // removeTexNameButton
            // 
            this.removeTexNameButton.Location = new System.Drawing.Point(213, 516);
            this.removeTexNameButton.Margin = new Padding(3, 4, 3, 4);
            this.removeTexNameButton.Name = "removeTexNameButton";
            this.removeTexNameButton.Size = new System.Drawing.Size(81, 31);
            this.removeTexNameButton.TabIndex = 41;
            this.removeTexNameButton.Text = "Remove";
            this.removeTexNameButton.UseVisualStyleBackColor = true;
            this.removeTexNameButton.Click += this.RemoveTexNameButton_Click;
            // 
            // addTexNameButton
            // 
            this.addTexNameButton.Location = new System.Drawing.Point(227, 477);
            this.addTexNameButton.Margin = new Padding(3, 4, 3, 4);
            this.addTexNameButton.Name = "addTexNameButton";
            this.addTexNameButton.Size = new System.Drawing.Size(48, 31);
            this.addTexNameButton.TabIndex = 13;
            this.addTexNameButton.Text = "Add";
            this.addTexNameButton.UseVisualStyleBackColor = true;
            this.addTexNameButton.Click += this.AddTexNameButton_Click;
            // 
            // texNameComboBox
            // 
            this.texNameComboBox.FormattingEnabled = true;
            this.texNameComboBox.Location = new System.Drawing.Point(9, 497);
            this.texNameComboBox.Margin = new Padding(3, 4, 3, 4);
            this.texNameComboBox.Name = "texNameComboBox";
            this.texNameComboBox.Size = new System.Drawing.Size(92, 28);
            this.texNameComboBox.TabIndex = 38;
            this.texNameComboBox.SelectedIndexChanged += this.TexNameComboBox_SelectedIndexChanged;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 473);
            this.label10.Margin = new Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "Texture mapping options:";
            // 
            // texTypeComboBox
            // 
            this.texTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.texTypeComboBox.FormattingEnabled = true;
            this.texTypeComboBox.Items.AddRange(new object[] { "Diffuse", "NormalMap", "Specular", "Bump", "Ambient", "Emissive", "Reflection", "Displacement" });
            this.texTypeComboBox.Location = new System.Drawing.Point(109, 497);
            this.texTypeComboBox.Margin = new Padding(3, 4, 3, 4);
            this.texTypeComboBox.Name = "texTypeComboBox";
            this.texTypeComboBox.Size = new System.Drawing.Size(90, 28);
            this.texTypeComboBox.TabIndex = 35;
            this.texTypeComboBox.SelectedIndexChanged += this.TexTypeComboBox_SelectedIndexChanged;
            this.texTypeComboBox.MouseHover += this.TexTypeComboBox_MouseHover;
            // 
            // uvTypesComboBox
            // 
            this.uvTypesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.uvTypesComboBox.FormattingEnabled = true;
            this.uvTypesComboBox.Items.AddRange(new object[] { "Diffuse", "NormalMap", "Specular", "Bump", "Ambient", "Emissive", "Reflection", "Displacement" });
            this.uvTypesComboBox.Location = new System.Drawing.Point(102, 439);
            this.uvTypesComboBox.Margin = new Padding(3, 4, 3, 4);
            this.uvTypesComboBox.Name = "uvTypesComboBox";
            this.uvTypesComboBox.Size = new System.Drawing.Size(121, 28);
            this.uvTypesComboBox.TabIndex = 34;
            this.uvTypesComboBox.SelectedIndexChanged += this.uvTypesComboBox_SelectedIndexChanged;
            // 
            // uvEnabledCheckBox
            // 
            this.uvEnabledCheckBox.AutoSize = true;
            this.uvEnabledCheckBox.Location = new System.Drawing.Point(230, 444);
            this.uvEnabledCheckBox.Margin = new Padding(3, 4, 3, 4);
            this.uvEnabledCheckBox.Name = "uvEnabledCheckBox";
            this.uvEnabledCheckBox.Size = new System.Drawing.Size(74, 24);
            this.uvEnabledCheckBox.TabIndex = 33;
            this.uvEnabledCheckBox.Text = "Export";
            this.uvEnabledCheckBox.UseVisualStyleBackColor = true;
            this.uvEnabledCheckBox.CheckedChanged += this.uvEnabledCheckBox_CheckedChanged;
            // 
            // uvsComboBox
            // 
            this.uvsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.uvsComboBox.FormattingEnabled = true;
            this.uvsComboBox.Items.AddRange(new object[] { "UV0", "UV1", "UV2", "UV3", "UV4", "UV5", "UV6", "UV7" });
            this.uvsComboBox.Location = new System.Drawing.Point(9, 439);
            this.uvsComboBox.Margin = new Padding(3, 4, 3, 4);
            this.uvsComboBox.Name = "uvsComboBox";
            this.uvsComboBox.Size = new System.Drawing.Size(85, 28);
            this.uvsComboBox.TabIndex = 32;
            this.uvsComboBox.SelectedIndexChanged += this.uvsComboBox_SelectedIndexChanged;
            this.uvsComboBox.MouseHover += this.uvsComboBox_MouseHover;
            // 
            // canExportCheckBox
            // 
            this.canExportCheckBox.AutoSize = true;
            this.canExportCheckBox.Location = new System.Drawing.Point(229, 383);
            this.canExportCheckBox.Margin = new Padding(3, 4, 3, 4);
            this.canExportCheckBox.Name = "canExportCheckBox";
            this.canExportCheckBox.Size = new System.Drawing.Size(74, 24);
            this.canExportCheckBox.TabIndex = 31;
            this.canExportCheckBox.Text = "Export";
            this.canExportCheckBox.UseVisualStyleBackColor = true;
            this.canExportCheckBox.CheckedChanged += this.CanExportCheckBox_CheckedChanged;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 356);
            this.label8.Margin = new Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Selected unity type can:";
            // 
            // canParseCheckBox
            // 
            this.canParseCheckBox.AutoSize = true;
            this.canParseCheckBox.Location = new System.Drawing.Point(160, 383);
            this.canParseCheckBox.Margin = new Padding(3, 4, 3, 4);
            this.canParseCheckBox.Name = "canParseCheckBox";
            this.canParseCheckBox.Size = new System.Drawing.Size(65, 24);
            this.canParseCheckBox.TabIndex = 29;
            this.canParseCheckBox.Text = "Parse";
            this.canParseCheckBox.UseVisualStyleBackColor = true;
            this.canParseCheckBox.CheckedChanged += this.CanParseCheckBox_CheckedChanged;
            // 
            // typesComboBox
            // 
            this.typesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.typesComboBox.FormattingEnabled = true;
            this.typesComboBox.Items.AddRange(new object[] { ClassIDType.Animation, ClassIDType.AnimationClip, ClassIDType.Animator, ClassIDType.AnimatorController, ClassIDType.AnimatorOverrideController, ClassIDType.AssetBundle, ClassIDType.AudioClip, ClassIDType.Avatar, ClassIDType.Font, ClassIDType.GameObject, ClassIDType.IndexObject, ClassIDType.Material, ClassIDType.Mesh, ClassIDType.MeshFilter, ClassIDType.MeshRenderer, ClassIDType.MiHoYoBinData, ClassIDType.MonoBehaviour, ClassIDType.MonoScript, ClassIDType.MovieTexture, ClassIDType.PlayerSettings, ClassIDType.RectTransform, ClassIDType.Shader, ClassIDType.SkinnedMeshRenderer, ClassIDType.Sprite, ClassIDType.SpriteAtlas, ClassIDType.TextAsset, ClassIDType.Texture2D, ClassIDType.Transform, ClassIDType.VideoClip, ClassIDType.ResourceManager });
            this.typesComboBox.Location = new System.Drawing.Point(8, 380);
            this.typesComboBox.Margin = new Padding(3, 4, 3, 4);
            this.typesComboBox.Name = "typesComboBox";
            this.typesComboBox.Size = new System.Drawing.Size(145, 28);
            this.typesComboBox.TabIndex = 28;
            this.typesComboBox.SelectedIndexChanged += this.TypesComboBox_SelectedIndexChanged;
            this.typesComboBox.MouseHover += this.TypesComboBox_MouseHover;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 415);
            this.label6.Margin = new Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "UV mapping options:";
            // 
            // minimalAssetMap
            // 
            this.minimalAssetMap.AutoSize = true;
            this.minimalAssetMap.Location = new System.Drawing.Point(8, 172);
            this.minimalAssetMap.Margin = new Padding(3, 4, 3, 4);
            this.minimalAssetMap.Name = "minimalAssetMap";
            this.minimalAssetMap.Size = new System.Drawing.Size(154, 24);
            this.minimalAssetMap.TabIndex = 17;
            this.minimalAssetMap.Text = "Minimal AssetMap";
            this.minimalAssetMap.UseVisualStyleBackColor = true;
            // 
            // assetGroupOptions
            // 
            this.assetGroupOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            this.assetGroupOptions.FormattingEnabled = true;
            this.assetGroupOptions.Items.AddRange(new object[] { "type name", "container path", "source file name", "do not group" });
            this.assetGroupOptions.Location = new System.Drawing.Point(8, 320);
            this.assetGroupOptions.Margin = new Padding(5);
            this.assetGroupOptions.Name = "assetGroupOptions";
            this.assetGroupOptions.Size = new System.Drawing.Size(197, 28);
            this.assetGroupOptions.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 295);
            this.label7.Margin = new Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Group exported assets by";
            // 
            // openAfterExport
            // 
            this.openAfterExport.AutoSize = true;
            this.openAfterExport.Checked = true;
            this.openAfterExport.CheckState = CheckState.Checked;
            this.openAfterExport.Location = new System.Drawing.Point(8, 104);
            this.openAfterExport.Margin = new Padding(5);
            this.openAfterExport.Name = "openAfterExport";
            this.openAfterExport.Size = new System.Drawing.Size(193, 24);
            this.openAfterExport.TabIndex = 10;
            this.openAfterExport.Text = "Open folder after export";
            this.openAfterExport.UseVisualStyleBackColor = true;
            // 
            // restoreExtensionName
            // 
            this.restoreExtensionName.AutoSize = true;
            this.restoreExtensionName.Checked = true;
            this.restoreExtensionName.CheckState = CheckState.Checked;
            this.restoreExtensionName.Location = new System.Drawing.Point(8, 32);
            this.restoreExtensionName.Margin = new Padding(5);
            this.restoreExtensionName.Name = "restoreExtensionName";
            this.restoreExtensionName.Size = new System.Drawing.Size(255, 24);
            this.restoreExtensionName.TabIndex = 9;
            this.restoreExtensionName.Text = "Restore TextAsset extension name";
            this.restoreExtensionName.UseVisualStyleBackColor = true;
            // 
            // key
            // 
            this.key.Hexadecimal = true;
            this.key.Location = new System.Drawing.Point(213, 137);
            this.key.Margin = new Padding(5, 4, 5, 4);
            this.key.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(63, 27);
            this.key.TabIndex = 8;
            this.key.MouseHover += this.Key_MouseHover;
            // 
            // encrypted
            // 
            this.encrypted.AutoSize = true;
            this.encrypted.Checked = true;
            this.encrypted.CheckState = CheckState.Checked;
            this.encrypted.Location = new System.Drawing.Point(8, 139);
            this.encrypted.Margin = new Padding(5, 4, 5, 4);
            this.encrypted.Name = "encrypted";
            this.encrypted.Size = new System.Drawing.Size(207, 24);
            this.encrypted.TabIndex = 12;
            this.encrypted.Text = "Encrypted MiHoYoBinData\r\n";
            this.encrypted.UseVisualStyleBackColor = true;
            // 
            // convertAudio
            // 
            this.convertAudio.AutoSize = true;
            this.convertAudio.Checked = true;
            this.convertAudio.CheckState = CheckState.Checked;
            this.convertAudio.Location = new System.Drawing.Point(8, 68);
            this.convertAudio.Margin = new Padding(5);
            this.convertAudio.Name = "convertAudio";
            this.convertAudio.Size = new System.Drawing.Size(245, 24);
            this.convertAudio.TabIndex = 6;
            this.convertAudio.Text = "Convert AudioClip to WAV(PCM)";
            this.convertAudio.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tohdr);
            this.panel1.Controls.Add(this.totga);
            this.panel1.Controls.Add(this.tojpg);
            this.panel1.Controls.Add(this.topng);
            this.panel1.Controls.Add(this.tobmp);
            this.panel1.Location = new System.Drawing.Point(27, 238);
            this.panel1.Margin = new Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 51);
            this.panel1.TabIndex = 5;
            // 
            // tohdr
            // 
            this.tohdr.AutoSize = true;
            this.tohdr.Location = new System.Drawing.Point(264, 11);
            this.tohdr.Margin = new Padding(5);
            this.tohdr.Name = "tohdr";
            this.tohdr.Size = new System.Drawing.Size(55, 24);
            this.tohdr.TabIndex = 2;
            this.tohdr.Text = "Hdr";
            this.tohdr.UseVisualStyleBackColor = true;
            // 
            // totga
            // 
            this.totga.AutoSize = true;
            this.totga.Location = new System.Drawing.Point(200, 11);
            this.totga.Margin = new Padding(5);
            this.totga.Name = "totga";
            this.totga.Size = new System.Drawing.Size(54, 24);
            this.totga.TabIndex = 2;
            this.totga.Text = "Tga";
            this.totga.UseVisualStyleBackColor = true;
            // 
            // tojpg
            // 
            this.tojpg.AutoSize = true;
            this.tojpg.Location = new System.Drawing.Point(131, 11);
            this.tojpg.Margin = new Padding(5);
            this.tojpg.Name = "tojpg";
            this.tojpg.Size = new System.Drawing.Size(61, 24);
            this.tojpg.TabIndex = 4;
            this.tojpg.Text = "Jpeg";
            this.tojpg.UseVisualStyleBackColor = true;
            // 
            // topng
            // 
            this.topng.AutoSize = true;
            this.topng.Checked = true;
            this.topng.Location = new System.Drawing.Point(71, 11);
            this.topng.Margin = new Padding(5);
            this.topng.Name = "topng";
            this.topng.Size = new System.Drawing.Size(55, 24);
            this.topng.TabIndex = 3;
            this.topng.TabStop = true;
            this.topng.Text = "Png";
            this.topng.UseVisualStyleBackColor = true;
            // 
            // tobmp
            // 
            this.tobmp.AutoSize = true;
            this.tobmp.Location = new System.Drawing.Point(6, 11);
            this.tobmp.Margin = new Padding(5);
            this.tobmp.Name = "tobmp";
            this.tobmp.Size = new System.Drawing.Size(61, 24);
            this.tobmp.TabIndex = 2;
            this.tobmp.Text = "Bmp";
            this.tobmp.UseVisualStyleBackColor = true;
            // 
            // converttexture
            // 
            this.converttexture.AutoSize = true;
            this.converttexture.Checked = true;
            this.converttexture.CheckState = CheckState.Checked;
            this.converttexture.Location = new System.Drawing.Point(8, 204);
            this.converttexture.Margin = new Padding(5);
            this.converttexture.Name = "converttexture";
            this.converttexture.Size = new System.Drawing.Size(153, 24);
            this.converttexture.TabIndex = 1;
            this.converttexture.Text = "Convert Texture2D";
            this.converttexture.UseVisualStyleBackColor = true;
            // 
            // collectAnimations
            // 
            this.collectAnimations.AutoSize = true;
            this.collectAnimations.Checked = true;
            this.collectAnimations.CheckState = CheckState.Checked;
            this.collectAnimations.Location = new System.Drawing.Point(9, 57);
            this.collectAnimations.Margin = new Padding(5, 4, 5, 4);
            this.collectAnimations.Name = "collectAnimations";
            this.collectAnimations.Size = new System.Drawing.Size(154, 24);
            this.collectAnimations.TabIndex = 24;
            this.collectAnimations.Text = "Collect animations";
            this.collectAnimations.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.exportMaterials);
            this.groupBox2.Controls.Add(this.collectAnimations);
            this.groupBox2.Controls.Add(this.exportBlendShape);
            this.groupBox2.Controls.Add(this.exportAnimations);
            this.groupBox2.Controls.Add(this.scaleFactor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.fbxFormat);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.fbxVersion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.boneSize);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.exportSkins);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.filterPrecision);
            this.groupBox2.Controls.Add(this.castToBone);
            this.groupBox2.Controls.Add(this.exportAllNodes);
            this.groupBox2.Controls.Add(this.eulerFilter);
            this.groupBox2.Location = new System.Drawing.Point(392, 20);
            this.groupBox2.Margin = new Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(434, 315);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fbx";
            // 
            // exportMaterials
            // 
            this.exportMaterials.AutoSize = true;
            this.exportMaterials.Location = new System.Drawing.Point(176, 128);
            this.exportMaterials.Margin = new Padding(5);
            this.exportMaterials.Name = "exportMaterials";
            this.exportMaterials.Size = new System.Drawing.Size(139, 24);
            this.exportMaterials.TabIndex = 25;
            this.exportMaterials.Text = "Export materials";
            this.exportMaterials.UseVisualStyleBackColor = true;
            // 
            // exportBlendShape
            // 
            this.exportBlendShape.AutoSize = true;
            this.exportBlendShape.Checked = true;
            this.exportBlendShape.CheckState = CheckState.Checked;
            this.exportBlendShape.Location = new System.Drawing.Point(8, 92);
            this.exportBlendShape.Margin = new Padding(5);
            this.exportBlendShape.Name = "exportBlendShape";
            this.exportBlendShape.Size = new System.Drawing.Size(155, 24);
            this.exportBlendShape.TabIndex = 22;
            this.exportBlendShape.Text = "Export blendshape";
            this.exportBlendShape.UseVisualStyleBackColor = true;
            // 
            // exportAnimations
            // 
            this.exportAnimations.AutoSize = true;
            this.exportAnimations.Checked = true;
            this.exportAnimations.CheckState = CheckState.Checked;
            this.exportAnimations.Location = new System.Drawing.Point(176, 57);
            this.exportAnimations.Margin = new Padding(5);
            this.exportAnimations.Name = "exportAnimations";
            this.exportAnimations.Size = new System.Drawing.Size(151, 24);
            this.exportAnimations.TabIndex = 21;
            this.exportAnimations.Text = "Export animations";
            this.exportAnimations.UseVisualStyleBackColor = true;
            // 
            // scaleFactor
            // 
            this.scaleFactor.DecimalPlaces = 2;
            this.scaleFactor.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            this.scaleFactor.Location = new System.Drawing.Point(117, 252);
            this.scaleFactor.Margin = new Padding(5);
            this.scaleFactor.Name = "scaleFactor";
            this.scaleFactor.Size = new System.Drawing.Size(67, 27);
            this.scaleFactor.TabIndex = 20;
            this.scaleFactor.TextAlign = HorizontalAlignment.Center;
            this.scaleFactor.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 257);
            this.label5.Margin = new Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "ScaleFactor";
            // 
            // fbxFormat
            // 
            this.fbxFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            this.fbxFormat.FormattingEnabled = true;
            this.fbxFormat.Items.AddRange(new object[] { "Binary", "Ascii" });
            this.fbxFormat.Location = new System.Drawing.Point(310, 167);
            this.fbxFormat.Margin = new Padding(5);
            this.fbxFormat.Name = "fbxFormat";
            this.fbxFormat.Size = new System.Drawing.Size(79, 28);
            this.fbxFormat.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 172);
            this.label4.Margin = new Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "FBXFormat";
            // 
            // fbxVersion
            // 
            this.fbxVersion.DropDownStyle = ComboBoxStyle.DropDownList;
            this.fbxVersion.FormattingEnabled = true;
            this.fbxVersion.Items.AddRange(new object[] { "6.1", "7.1", "7.2", "7.3", "7.4", "7.5" });
            this.fbxVersion.Location = new System.Drawing.Point(310, 209);
            this.fbxVersion.Margin = new Padding(5);
            this.fbxVersion.Name = "fbxVersion";
            this.fbxVersion.Size = new System.Drawing.Size(79, 28);
            this.fbxVersion.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 215);
            this.label3.Margin = new Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "FBXVersion";
            // 
            // boneSize
            // 
            this.boneSize.Location = new System.Drawing.Point(117, 209);
            this.boneSize.Margin = new Padding(5);
            this.boneSize.Name = "boneSize";
            this.boneSize.Size = new System.Drawing.Size(67, 27);
            this.boneSize.TabIndex = 11;
            this.boneSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 215);
            this.label2.Margin = new Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "BoneSize";
            // 
            // exportSkins
            // 
            this.exportSkins.AutoSize = true;
            this.exportSkins.Checked = true;
            this.exportSkins.CheckState = CheckState.Checked;
            this.exportSkins.Location = new System.Drawing.Point(176, 23);
            this.exportSkins.Margin = new Padding(5);
            this.exportSkins.Name = "exportSkins";
            this.exportSkins.Size = new System.Drawing.Size(109, 24);
            this.exportSkins.TabIndex = 8;
            this.exportSkins.Text = "Export skins";
            this.exportSkins.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 172);
            this.label1.Margin = new Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "FilterPrecision";
            // 
            // filterPrecision
            // 
            this.filterPrecision.DecimalPlaces = 2;
            this.filterPrecision.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            this.filterPrecision.Location = new System.Drawing.Point(117, 169);
            this.filterPrecision.Margin = new Padding(5);
            this.filterPrecision.Name = "filterPrecision";
            this.filterPrecision.Size = new System.Drawing.Size(67, 27);
            this.filterPrecision.TabIndex = 6;
            this.filterPrecision.Value = new decimal(new int[] { 25, 0, 0, 131072 });
            // 
            // castToBone
            // 
            this.castToBone.AutoSize = true;
            this.castToBone.Location = new System.Drawing.Point(176, 92);
            this.castToBone.Margin = new Padding(5);
            this.castToBone.Name = "castToBone";
            this.castToBone.Size = new System.Drawing.Size(179, 24);
            this.castToBone.TabIndex = 5;
            this.castToBone.Text = "All nodes cast to bone";
            this.castToBone.UseVisualStyleBackColor = true;
            // 
            // exportAllNodes
            // 
            this.exportAllNodes.AutoSize = true;
            this.exportAllNodes.Checked = true;
            this.exportAllNodes.CheckState = CheckState.Checked;
            this.exportAllNodes.Location = new System.Drawing.Point(8, 128);
            this.exportAllNodes.Margin = new Padding(5);
            this.exportAllNodes.Name = "exportAllNodes";
            this.exportAllNodes.Size = new System.Drawing.Size(138, 24);
            this.exportAllNodes.TabIndex = 4;
            this.exportAllNodes.Text = "Export all nodes";
            this.exportAllNodes.UseVisualStyleBackColor = true;
            // 
            // eulerFilter
            // 
            this.eulerFilter.AutoSize = true;
            this.eulerFilter.Checked = true;
            this.eulerFilter.CheckState = CheckState.Checked;
            this.eulerFilter.Location = new System.Drawing.Point(9, 23);
            this.eulerFilter.Margin = new Padding(5);
            this.eulerFilter.Name = "eulerFilter";
            this.eulerFilter.Size = new System.Drawing.Size(97, 24);
            this.eulerFilter.TabIndex = 3;
            this.eulerFilter.Text = "EulerFilter";
            this.eulerFilter.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(343, 571);
            this.Reset.Margin = new Padding(3, 4, 3, 4);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(101, 35);
            this.Reset.TabIndex = 12;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += this.Reset_Click;
            // 
            // ExportOptions
            // 
            this.AcceptButton = this.OKbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(838, 623);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OKbutton);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.Margin = new Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Export options";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.key).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.scaleFactor).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.boneSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.filterPrecision).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button OKbutton;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox converttexture;
        private System.Windows.Forms.RadioButton tojpg;
        private System.Windows.Forms.RadioButton topng;
        private System.Windows.Forms.RadioButton tobmp;
        private System.Windows.Forms.RadioButton totga;
        private System.Windows.Forms.RadioButton tohdr;
        private System.Windows.Forms.CheckBox convertAudio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown boneSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox exportSkins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown filterPrecision;
        private System.Windows.Forms.CheckBox castToBone;
        private System.Windows.Forms.CheckBox exportAllNodes;
        private System.Windows.Forms.CheckBox eulerFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox fbxVersion;
        private System.Windows.Forms.ComboBox fbxFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown scaleFactor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox exportBlendShape;
        private System.Windows.Forms.CheckBox exportAnimations;
        private System.Windows.Forms.ComboBox assetGroupOptions;
        private System.Windows.Forms.CheckBox restoreExtensionName;
        private System.Windows.Forms.CheckBox openAfterExport;
        private System.Windows.Forms.CheckBox collectAnimations;
        private System.Windows.Forms.CheckBox encrypted;
        private System.Windows.Forms.NumericUpDown key;
        private System.Windows.Forms.CheckBox minimalAssetMap;
        private System.Windows.Forms.Label label7;
        private Label label6;
        private Label label8;
        private CheckBox canParseCheckBox;
        private ComboBox typesComboBox;
        private CheckBox canExportCheckBox;
        private ComboBox uvTypesComboBox;
        private CheckBox uvEnabledCheckBox;
        private ComboBox uvsComboBox;
        private Label label10;
        private ComboBox texTypeComboBox;
        private ToolTip toolTip;
        private Button Reset;
        private ComboBox texNameComboBox;
        private Button addTexNameButton;
        private Button removeTexNameButton;
        private CheckBox exportMaterials;
    }
}
