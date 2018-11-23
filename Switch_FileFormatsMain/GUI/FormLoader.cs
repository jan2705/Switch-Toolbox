﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Switch_Toolbox.Library;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Bfres.Structs;

namespace FirstPlugin
{
    class FormLoader
    {
        public static void LoadEditor(object type, string Text)
        {
            /*    foreach (Control control in FirstPlugin.MainF.Controls)
                {
                    if (control is DockPanel)
                    {
                        if (FirstPlugin.DockedEditorS == null)
                        {
                            FirstPlugin.DockedEditorS = new DockContent();
                            FirstPlugin.DockedEditorS.Show((DockPanel)control, PluginRuntime.FSHPDockState);
                        }
                    }
                }

                if (!PropEditorIsActive(FirstPlugin.DockedEditorS))
                {
                    FirstPlugin.DockedEditorS.Controls.Clear();
                    BfresProperties BfresProperties = new BfresProperties();
                    BfresProperties.Text = Text;
                    BfresProperties.Dock = DockStyle.Fill;
                    BfresProperties.LoadProperty(type);
                    FirstPlugin.DockedEditorS.Controls.Add(BfresProperties);
                }

                bool PropEditorIsActive(DockContent dock)
                {
                    foreach (Control ctrl in dock.Controls)
                    {
                        if (ctrl is BfresProperties)
                        {
                            ((BfresProperties)ctrl).LoadProperty(type);
                            return true;
                        }
                    }
                    return false;
                }*/
        }
        public static void LoadBoneEditor(BfresBone bone)
        {
            BfresBoneEditor BfresBone = new BfresBoneEditor();
            BfresBone.Text = bone.Text;
            BfresBone.Dock = DockStyle.Fill;
            BfresBone.LoadBone(bone);
            LibraryGUI.Instance.LoadDockContent(BfresBone, PluginRuntime.FSHPDockState);
        }
        public static bool BoneEditorIsActive(DockContent dock, BfresBone bone)
        {
            foreach (Control ctrl in dock.Controls)
            {
                if (ctrl is BfresBoneEditor)
                {
                    ((BfresBoneEditor)ctrl).LoadBone(bone);
                    return true;
                }
            }
            return false;
        }

        public static void LoadMatEditor(FMAT mat)
        {
            FMATEditor editor = new FMATEditor();
            editor.Text = mat.Text;
            editor.Dock = DockStyle.Fill;
            editor.LoadMaterial(mat);
            LibraryGUI.Instance.LoadDockContent(editor, PluginRuntime.FSHPDockState);
        }

        public static void LoadShapeEditor(FSHP fshp)
        {
            FSHPEditor BfresProperties = new FSHPEditor();
            BfresProperties.Text = fshp.Text;
            BfresProperties.Dock = DockStyle.Fill;
            BfresProperties.LoadObject((FMDL)fshp.Parent.Parent, fshp);
            LibraryGUI.Instance.LoadDockContent(BfresProperties, PluginRuntime.FSHPDockState);
        }
    }
}
