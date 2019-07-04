/*
 * Project : N3DT Scanner - TDD 2013/2014
 * Author  : Christopher Rejas
 * Date    : 2014-04-08
 */

using System;

namespace N3DTScanner
{
    interface IFileFormat
    {
        void Load(String path);
        void Export(String path);
    }
}
