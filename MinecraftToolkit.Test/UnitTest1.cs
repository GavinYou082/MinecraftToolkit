using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinecraftToolkit.Nbt;
using System;
using System.Collections.Generic;
using System.IO;

namespace MinecraftToolkit.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TagCompoundAPISample()
        {
            //Initialize tag compound
            TagCompound compound = new();
            compound.Add("double", new TagDouble(10.0d));
            
            //Get a TagDouble from a compound tag
            var tag = compound["double"];
            compound.TryGetChildTag("double", out TagDouble dtag);
            //Get a TagCompound from a compound tag
            var child = compound["child"] as TagCompound;
            int count = child.Count;

            //Get a value from an INbtTag
            var val = tag.GetValue<double>();

            Console.WriteLine(val);
        }

        [TestMethod]
        public void TestMethod1()
        {
            //NBTFile nf = new NBTFile(@"D:\Minecraft\.minecraft\saves\Survival\level.dat");
            //NbtTree tree = new NbtTree(nf.GetDataInputStream());

            //return;


            //List<string> failed = new List<string>();
            //List<NbtTree> regions = new List<NbtTree>();
            //foreach (var item in Directory.EnumerateFiles(@"D:\Minecraft\.minecraft\saves\Survival\region"))
            //{
            //    try
            //    {
            //        RegionFile file = new RegionFile(item);
            //        for (int i = 0; i < 32; i++)
            //        {
            //            for (int j = 0; j < 32; j++)
            //            {
            //                NbtTree tree = new NbtTree(file.GetChunkDataInputStream(i, j));
            //                regions.Add(tree);
            //            }
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        failed.Add(item);
            //    }
            //}
            //return;
        }

        [TestMethod]
        public void TestMethod2()
        {
            TagIntArray a = new TagIntArray(new int[] { 1, 2 });
            var clone=a.Clone();
            return;
        }
    }
}
