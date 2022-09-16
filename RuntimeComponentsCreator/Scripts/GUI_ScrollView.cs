using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RuntimeComponents.UI
{
 public class GUI_ScrollView : MonoBehaviour
 {
    // Start is called before the first frame update
    //public static void ScrollView(GameObject Canvas)
	public void Start()
    {
	   GameObject Canvas = GameObject.Find("Canvas");
       Texture2D backgroundtex = new Texture2D(2, 2);
byte[] Background = new byte[] 
{
	0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D,
	0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x00, 0x20,
	0x08, 0x06, 0x00, 0x00, 0x00, 0x73, 0x7A, 0x7A, 0xF4, 0x00, 0x00, 0x00,
	0x01, 0x73, 0x52, 0x47, 0x42, 0x00, 0xAE, 0xCE, 0x1C, 0xE9, 0x00, 0x00,
	0x00, 0x04, 0x67, 0x41, 0x4D, 0x41, 0x00, 0x00, 0xB1, 0x8F, 0x0B, 0xFC,
	0x61, 0x05, 0x00, 0x00, 0x00, 0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00,
	0x0E, 0xC3, 0x00, 0x00, 0x0E, 0xC3, 0x01, 0xC7, 0x6F, 0xA8, 0x64, 0x00,
	0x00, 0x01, 0x93, 0x49, 0x44, 0x41, 0x54, 0x58, 0x47, 0xED, 0x97, 0xD1,
	0x6A, 0x83, 0x30, 0x14, 0x86, 0xBD, 0xDA, 0xAB, 0x0C, 0x84, 0x41, 0xB5,
	0x3E, 0xD9, 0x2E, 0x0A, 0x3E, 0x84, 0x58, 0xD9, 0xB3, 0x88, 0x17, 0x22,
	0xBE, 0x80, 0x38, 0x11, 0x27, 0x85, 0xBD, 0xC4, 0x60, 0x30, 0x18, 0x14,
	0xDC, 0xF9, 0x43, 0x4F, 0x38, 0x75, 0x69, 0xA7, 0x25, 0x6E, 0xBB, 0xF0,
	0xE2, 0x23, 0x59, 0xE6, 0xF9, 0xFF, 0x3F, 0xD1, 0x92, 0xC4, 0x71, 0x5D,
	0xF7, 0x0C, 0xDF, 0xF7, 0x9D, 0x20, 0x08, 0x14, 0xE8, 0x03, 0xCF, 0xF3,
	0x74, 0x7F, 0x2A, 0xB2, 0x46, 0xEA, 0x8D, 0xFD, 0xD4, 0x83, 0xE8, 0xC8,
	0x16, 0xD8, 0x0E, 0xC0, 0xBA, 0xF0, 0xC0, 0x18, 0xB7, 0x3A, 0x1D, 0x06,
	0x00, 0xFF, 0x4D, 0xDC, 0xD3, 0x03, 0x11, 0x51, 0x51, 0xE1, 0x91, 0xDA,
	0x61, 0x0E, 0xA7, 0x9A, 0x8A, 0x88, 0xA0, 0xC5, 0xBA, 0x63, 0x1F, 0x9D,
	0x4A, 0xB6, 0xC4, 0x23, 0xF1, 0x11, 0x45, 0xD1, 0x90, 0xA6, 0xE9, 0xD0,
	0x75, 0xDD, 0xD0, 0xF7, 0xFD, 0x2C, 0x50, 0x83, 0x5A, 0x68, 0x40, 0xEB,
	0xA4, 0xF9, 0xCD, 0x4B, 0x75, 0x04, 0x77, 0x94, 0x38, 0xDB, 0xED, 0x76,
	0x43, 0x59, 0x96, 0x46, 0xE1, 0x5B, 0x80, 0x16, 0x34, 0xA1, 0x0D, 0x0F,
	0xE9, 0xC9, 0x33, 0x66, 0xF6, 0x61, 0x18, 0x1A, 0x45, 0x6C, 0x00, 0x6D,
	0xBC, 0x12, 0x42, 0x7F, 0x1F, 0xCE, 0x76, 0xBB, 0x65, 0x1E, 0x28, 0xC0,
	0xB1, 0x6D, 0x5B, 0x63, 0xB1, 0x0D, 0x9A, 0xA6, 0x51, 0xDF, 0xC6, 0x66,
	0xB3, 0x71, 0x09, 0x07, 0x9C, 0xCD, 0x3E, 0x8E, 0x63, 0x63, 0xA1, 0x4D,
	0xF0, 0x4D, 0xC8, 0x55, 0x90, 0x01, 0x0E, 0x45, 0x51, 0x18, 0x8B, 0x6C,
	0x92, 0xE7, 0x39, 0x02, 0xBC, 0xE8, 0x00, 0xDC, 0x21, 0x3E, 0x97, 0x5C,
	0x7E, 0xA6, 0xAA, 0x2A, 0xBC, 0x86, 0x37, 0x9E, 0xB8, 0x0C, 0x60, 0x2C,
	0x58, 0x02, 0x78, 0xB1, 0xEF, 0x1A, 0x60, 0x0D, 0xB0, 0x06, 0x58, 0x03,
	0xAC, 0x01, 0xFE, 0x55, 0x80, 0x5F, 0xD9, 0x8C, 0xEA, 0xBA, 0x86, 0xF9,
	0x3B, 0xFB, 0xCA, 0x00, 0xAF, 0x36, 0x8F, 0x61, 0x97, 0xB8, 0xB6, 0x1D,
	0x3F, 0x25, 0x49, 0x62, 0x2C, 0xB2, 0x09, 0x0E, 0x3D, 0xB4, 0x0D, 0xEF,
	0xF5, 0x76, 0x3C, 0x3E, 0x92, 0xDD, 0x72, 0x02, 0x9E, 0x0A, 0x5E, 0x31,
	0x3C, 0xE0, 0xC5, 0xBE, 0x72, 0x05, 0xD4, 0x2A, 0x2C, 0x7D, 0x28, 0x95,
	0xB3, 0x07, 0xF2, 0x48, 0x0E, 0xFE, 0xE6, 0x58, 0x8E, 0x8E, 0x6C, 0x09,
	0x7D, 0x31, 0xC9, 0xB2, 0xCC, 0x28, 0x3A, 0x05, 0xD4, 0xFE, 0x78, 0x31,
	0xB9, 0x74, 0x65, 0x22, 0xF8, 0x6A, 0xF6, 0x4C, 0xF0, 0x6F, 0x77, 0x2E,
	0xA8, 0xBD, 0x7E, 0x35, 0xA3, 0x07, 0xD4, 0x00, 0xB7, 0x48, 0x05, 0xF0,
	0x4F, 0x8C, 0xD9, 0x00, 0x5A, 0xAC, 0xCB, 0x1E, 0xDC, 0xAA, 0x8E, 0x84,
	0x0B, 0x6C, 0x07, 0x60, 0xBD, 0x73, 0x3F, 0xD7, 0xF9, 0x02, 0xA1, 0x98,
	0xE9, 0x4A, 0xC9, 0x1C, 0x84, 0x77, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45,
	0x4E, 0x44, 0xAE, 0x42, 0x60, 0x82
};
	     Texture2D tex = new Texture2D(2, 2);
	     byte[] UISprite = new byte[] 
          {
	0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D,
	0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x00, 0x20,
	0x08, 0x06, 0x00, 0x00, 0x00, 0x73, 0x7A, 0x7A, 0xF4, 0x00, 0x00, 0x00,
	0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00, 0x0E, 0xC4, 0x00, 0x00, 0x0E,
	0xC4, 0x01, 0x95, 0x2B, 0x0E, 0x1B, 0x00, 0x00, 0x02, 0xA8, 0x49, 0x44,
	0x41, 0x54, 0x78, 0x9C, 0xED, 0x57, 0x4D, 0x68, 0x1A, 0x41, 0x14, 0x7E,
	0xEA, 0xBA, 0x1A, 0x2F, 0xF5, 0xE0, 0x21, 0x50, 0x45, 0x84, 0x88, 0x78,
	0x28, 0x04, 0x45, 0x04, 0x89, 0x08, 0x85, 0xC2, 0xF6, 0x24, 0x11, 0x44,
	0x72, 0x13, 0x82, 0x81, 0x8A, 0x3F, 0xF8, 0x43, 0x45, 0xD2, 0x63, 0xA0,
	0xA4, 0xF8, 0x73, 0x11, 0x84, 0x48, 0x6E, 0x81, 0x90, 0x4B, 0x88, 0x87,
	0x42, 0xA0, 0x50, 0x28, 0x01, 0x41, 0x44, 0x09, 0x04, 0x0A, 0xE2, 0xC9,
	0x28, 0x81, 0xE4, 0x2C, 0x88, 0xBF, 0xF4, 0xCD, 0xE2, 0x2E, 0xD6, 0x43,
	0x9B, 0x15, 0x17, 0x2F, 0x7E, 0xF0, 0x31, 0xBB, 0x3B, 0x6F, 0xDF, 0x7C,
	0x33, 0x6F, 0x67, 0xE7, 0x3D, 0x6A, 0x38, 0x1C, 0xC2, 0x3C, 0xE2, 0xF1,
	0x38, 0xD8, 0xED, 0x76, 0x70, 0x3A, 0x9D, 0x70, 0x7D, 0x7D, 0x0D, 0xF5,
	0x7A, 0x1D, 0x9A, 0xCD, 0x26, 0x4C, 0xA7, 0x53, 0x10, 0x02, 0xA9, 0x54,
	0x0A, 0x26, 0x93, 0x09, 0xAC, 0x56, 0x2B, 0x78, 0x3C, 0x1E, 0xB8, 0xBB,
	0xBB, 0x83, 0x6A, 0xB5, 0x0A, 0xB9, 0x5C, 0xEE, 0x2F, 0x3B, 0x0A, 0xD6,
	0x8C, 0x7F, 0x09, 0x30, 0x21, 0x8F, 0x90, 0x2E, 0xE4, 0x2E, 0x52, 0x26,
	0xD0, 0xF7, 0x04, 0x79, 0x8F, 0xFC, 0x85, 0x3C, 0x43, 0x36, 0x85, 0x08,
	0x88, 0x1F, 0x1C, 0x1C, 0x9C, 0x04, 0x83, 0xC1, 0xAD, 0xE3, 0xE3, 0x63,
	0x76, 0x29, 0xC9, 0x92, 0x0A, 0x01, 0x86, 0x4C, 0x86, 0xA1, 0xB3, 0x62,
	0x08, 0xAD, 0xE8, 0xEB, 0x13, 0xFA, 0xFA, 0x82, 0x8F, 0x73, 0x8B, 0x76,
	0x8B, 0x02, 0x68, 0x64, 0xB9, 0xD3, 0xE9, 0x30, 0x57, 0x57, 0x57, 0xA0,
	0xD3, 0xE9, 0x60, 0x59, 0x10, 0xC1, 0x66, 0xB3, 0x99, 0xA5, 0xCB, 0xE5,
	0xDA, 0xBA, 0xB8, 0xB8, 0xC8, 0xE2, 0xE3, 0x0F, 0x48, 0x37, 0x92, 0xFF,
	0xF0, 0xA8, 0x76, 0xBB, 0xCD, 0xBF, 0x74, 0x73, 0x73, 0xF3, 0x4D, 0xAF,
	0xD7, 0x33, 0xC9, 0x64, 0x12, 0x56, 0x09, 0x32, 0x91, 0x74, 0x3A, 0x0D,
	0x99, 0x4C, 0x86, 0x29, 0x14, 0x0A, 0x5F, 0xDD, 0x6E, 0x77, 0x82, 0x17,
	0x30, 0x67, 0xF7, 0x0E, 0x67, 0x1D, 0xAA, 0x54, 0x2A, 0xEC, 0x0D, 0xF9,
	0xEA, 0xC7, 0xE3, 0x31, 0xDB, 0x0A, 0xDD, 0x01, 0x1C, 0xC8, 0x2A, 0x10,
	0x52, 0x14, 0xC5, 0xB6, 0xE1, 0x70, 0x18, 0xF6, 0xF6, 0xF6, 0xA2, 0x28,
	0xE0, 0x1C, 0xBB, 0x7F, 0xB3, 0x02, 0x70, 0xD6, 0x9C, 0xFD, 0x21, 0x6E,
	0x41, 0x99, 0x5C, 0x2E, 0x67, 0x07, 0x5E, 0xDC, 0x9E, 0xCB, 0x80, 0x13,
	0x4F, 0xFC, 0xD1, 0x34, 0x0D, 0x0A, 0x85, 0x02, 0xA2, 0xD1, 0xA8, 0xAC,
	0x5C, 0x2E, 0x1F, 0x62, 0x37, 0xBB, 0x0A, 0x14, 0x37, 0x63, 0x04, 0x93,
	0xCF, 0xE7, 0x61, 0x30, 0x18, 0xC0, 0x64, 0x32, 0x81, 0x55, 0x83, 0x4C,
	0x88, 0xF8, 0x75, 0x38, 0x1C, 0x90, 0x4A, 0xA5, 0x18, 0x5E, 0xC0, 0xD3,
	0xD3, 0x13, 0x67, 0x63, 0xD0, 0x68, 0x34, 0xA2, 0x0C, 0xCE, 0x81, 0xF8,
	0x56, 0xAB, 0xD5, 0xF0, 0xF2, 0xF2, 0xF2, 0x96, 0x7B, 0x46, 0x8D, 0x46,
	0x23, 0xEE, 0x9A, 0x96, 0x48, 0x24, 0x20, 0x36, 0x94, 0x4A, 0x25, 0xF4,
	0x7A, 0xBD, 0x37, 0xBC, 0x00, 0x58, 0x33, 0x36, 0x02, 0x36, 0x02, 0x36,
	0x02, 0x36, 0x02, 0x36, 0x02, 0x28, 0x72, 0xFC, 0xCE, 0x30, 0xC4, 0x73,
	0x81, 0x9E, 0xBB, 0x17, 0x05, 0xFD, 0x7E, 0x1F, 0x54, 0x2A, 0x55, 0x8F,
	0x17, 0xB0, 0xBD, 0xBD, 0xCD, 0x5D, 0x3F, 0x3E, 0x3F, 0x3F, 0xEF, 0x68,
	0xB5, 0x5A, 0x51, 0x05, 0xE0, 0x18, 0x80, 0x63, 0x3E, 0xF2, 0x02, 0xC8,
	0xF9, 0x3C, 0xC3, 0x2D, 0xE6, 0xED, 0x21, 0xB1, 0x05, 0xD4, 0x6A, 0x35,
	0x52, 0x77, 0xFC, 0xE0, 0x05, 0x90, 0xA2, 0x61, 0x86, 0x33, 0x92, 0xBD,
	0xEE, 0xEF, 0xEF, 0xCB, 0x84, 0x66, 0xC0, 0xAF, 0x05, 0x39, 0xFA, 0x31,
	0x27, 0x9C, 0x5C, 0x5E, 0x5E, 0x9E, 0xF3, 0x02, 0x48, 0xF5, 0x33, 0xC3,
	0x83, 0xD7, 0xEB, 0x2D, 0xA2, 0x41, 0x28, 0x12, 0x89, 0x88, 0x22, 0xA0,
	0x58, 0x2C, 0x82, 0xCF, 0xE7, 0x2B, 0x60, 0x1A, 0xF8, 0xC0, 0x0B, 0x88,
	0xC5, 0x62, 0xF3, 0x36, 0x09, 0xCC, 0x0B, 0x77, 0xB2, 0xD9, 0x2C, 0x83,
	0x86, 0xB0, 0xAA, 0x70, 0x74, 0xBB, 0x5D, 0x20, 0x69, 0x3E, 0x66, 0x42,
	0xB7, 0x58, 0x9A, 0x7D, 0x9E, 0xEF, 0x5B, 0xDC, 0x86, 0x43, 0x8C, 0xCF,
	0x47, 0x6C, 0xE3, 0x7E, 0xBF, 0xFF, 0x24, 0x10, 0x08, 0x6C, 0x59, 0x2C,
	0x16, 0x30, 0x1A, 0x8D, 0x4B, 0x0D, 0xDC, 0x6A, 0xB5, 0xA0, 0xD1, 0x68,
	0x40, 0xA9, 0x54, 0xEA, 0x93, 0xC2, 0xC4, 0x60, 0x30, 0xFC, 0xB7, 0x30,
	0x61, 0x8B, 0x52, 0x44, 0x0E, 0xDB, 0xEF, 0x18, 0x9E, 0xA3, 0xD3, 0xD3,
	0xD3, 0xF7, 0x58, 0xE1, 0xEC, 0x2E, 0x23, 0x00, 0x2B, 0xAA, 0x7B, 0x9B,
	0xCD, 0xF6, 0x13, 0x63, 0x2E, 0xB8, 0x34, 0x83, 0xD9, 0x0B, 0x09, 0x10,
	0x19, 0x6B, 0xFF, 0x13, 0xFE, 0x01, 0x06, 0xD2, 0x00, 0x12, 0x3C, 0x75,
	0xD4, 0xE7, 0x00, 0x00, 0x00, 0x00, 0x49, 0x45, 0x4E, 0x44, 0xAE, 0x42,
	0x60, 0x82
          };
Texture2D UImasktex = new Texture2D(2, 2);
byte[] UIMaskSprite = new byte[] 
{
	0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A, 0x00, 0x00, 0x00, 0x0D,
	0x49, 0x48, 0x44, 0x52, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x00, 0x20,
	0x08, 0x06, 0x00, 0x00, 0x00, 0x73, 0x7A, 0x7A, 0xF4, 0x00, 0x00, 0x00,
	0x09, 0x70, 0x48, 0x59, 0x73, 0x00, 0x00, 0x0E, 0xC4, 0x00, 0x00, 0x0E,
	0xC4, 0x01, 0x95, 0x2B, 0x0E, 0x1B, 0x00, 0x00, 0x00, 0xAD, 0x49, 0x44,
	0x41, 0x54, 0x78, 0x9C, 0xED, 0x96, 0xD9, 0x0A, 0x80, 0x20, 0x10, 0x45,
	0xA5, 0x0D, 0xFA, 0xFF, 0x6F, 0x8D, 0x1E, 0x22, 0xCD, 0x81, 0x89, 0x0A,
	0xB3, 0x46, 0x1D, 0x51, 0x6A, 0x2E, 0x5C, 0x7A, 0x72, 0x3C, 0xD2, 0x76,
	0x3A, 0x63, 0x8C, 0x2A, 0x99, 0x4E, 0x15, 0x8E, 0x00, 0xBC, 0x01, 0xF4,
	0xD8, 0x36, 0x72, 0xFE, 0x6A, 0xBB, 0x60, 0x83, 0x00, 0x1A, 0xDB, 0x11,
	0xAF, 0x29, 0x69, 0xB1, 0x83, 0xED, 0x6C, 0xAB, 0xA9, 0x00, 0x1C, 0x9B,
	0x9F, 0xB3, 0x1F, 0x68, 0xA2, 0x00, 0xF4, 0xCC, 0x9B, 0x9F, 0x21, 0x60,
	0xF6, 0xE5, 0x76, 0xF8, 0x00, 0x72, 0x85, 0x04, 0x10, 0xFB, 0xC0, 0x51,
	0xE2, 0xCC, 0xAE, 0xFE, 0x35, 0x14, 0x00, 0x01, 0x10, 0x00, 0x01, 0x10,
	0x80, 0xCF, 0x01, 0x38, 0x0A, 0x7E, 0x07, 0x00, 0x1A, 0x95, 0xEB, 0x8F,
	0x48, 0x32, 0xA2, 0x25, 0x23, 0x80, 0xE3, 0x86, 0x3E, 0x00, 0x70, 0x38,
	0x6E, 0x2B, 0xD2, 0x54, 0x00, 0x08, 0x08, 0x24, 0xA7, 0x17, 0x6A, 0x9C,
	0xE9, 0xC4, 0x07, 0x00, 0x0B, 0x40, 0x20, 0x53, 0xB4, 0xDC, 0xA8, 0xE3,
	0xD4, 0xC1, 0x5A, 0xBE, 0xE7, 0x71, 0x31, 0x47, 0x7E, 0xF7, 0x1D, 0xA8,
	0x0F, 0x60, 0x03, 0xD0, 0x21, 0x1E, 0x7D, 0x59, 0xAC, 0x6C, 0x3D, 0x00,
	0x00, 0x00, 0x00, 0x49, 0x45, 0x4E, 0x44, 0xAE, 0x42, 0x60, 0x82
};
          UImasktex.LoadImage(UIMaskSprite);
          tex.LoadImage(UISprite);
          backgroundtex.LoadImage(Background);
          GameObject scrollView = new GameObject("Scroll View", typeof(Image), typeof(ScrollRect));
          scrollView.transform.SetParent(Canvas.transform);
          scrollView.GetComponent<Image>().type = Image.Type.Sliced;
          scrollView.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.4f);
          scrollView.GetComponent<RectTransform>().sizeDelta = new Vector2 (200, 200);
          scrollView.GetComponent<Image>().sprite = Sprite.Create(backgroundtex, new Rect(0.0f, 0.0f, backgroundtex.width, backgroundtex.height), new Vector2(16f, 16f), 200.0f, 0, SpriteMeshType.Tight, new Vector4 (10,10,10,10));
          GameObject Viewport = new GameObject("Viewport", typeof(Image), typeof(Mask));
          Viewport.GetComponent<RectTransform>().pivot = new Vector2(0,1);
          Viewport.transform.SetParent(scrollView.transform);
          Viewport.GetComponent<Image>().sprite = Sprite.Create(UImasktex, new Rect(0.0f, 0.0f, UImasktex.width, UImasktex.height), new Vector2(16f, 16f), 200.0f, 0, SpriteMeshType.Tight, new Vector4 (10,10,10,10));
          Viewport.GetComponent<Image>().type = Image.Type.Sliced;
          Viewport.GetComponent<Mask>().showMaskGraphic = false;
          GameObject Content = new GameObject("Content", typeof(RectTransform)); 
          Content.GetComponent<RectTransform>().sizeDelta = new Vector2(+100,+300);
          Content.GetComponent<RectTransform>().anchorMin = new Vector2(0,1);
          Content.GetComponent<RectTransform>().anchorMax = new Vector2(1,1);
          Content.GetComponent<RectTransform>().pivot = new Vector2(0,1);
          Content.transform.SetParent(Viewport.transform);
          GameObject ScrollbarH = new GameObject("Scrollbar Horizontal", typeof(Image), typeof(Scrollbar));
          ScrollbarH.transform.SetParent(scrollView.transform);
          GameObject slidingArea = new GameObject("Sliding Area", typeof(RectTransform));
          slidingArea.transform.SetParent(ScrollbarH.transform);
          GameObject handle = new GameObject("Handle", typeof(Image));
          handle.GetComponent<Image>().type = Image.Type.Sliced;
          handle.GetComponent<Image>().sprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(16f, 16f), 200.0f, 0, SpriteMeshType.Tight, new Vector4 (10,10,10,10));
          handle.transform.SetParent(slidingArea.transform);
          handle.GetComponent<RectTransform>().sizeDelta = new Vector2 (20, 20);
          GameObject ScrollbarV = new GameObject("Scrollbar Vertical", typeof(Image), typeof(Scrollbar));
          ScrollbarV.transform.SetParent(scrollView.transform);
          ScrollbarV.GetComponent<RectTransform>().sizeDelta = new Vector2(20,0);
          ScrollbarV.GetComponent<RectTransform>().anchorMin = new Vector2(1,0);
          ScrollbarV.GetComponent<RectTransform>().anchorMax = new Vector2(1,0);
          ScrollbarV.GetComponent<RectTransform>().pivot = new Vector2(1,1);
          GameObject slidingAreaV = new GameObject("Sliding Area", typeof(RectTransform));
		  slidingAreaV.GetComponent<RectTransform>().anchoredPosition = new Vector2(+35,30);
          slidingAreaV.GetComponent<RectTransform>().sizeDelta = new Vector2 (+250, +90);
          slidingAreaV.transform.SetParent(ScrollbarV.transform);
          GameObject handle1 = new GameObject("Handle", typeof(Image));
          handle1.GetComponent<Image>().type = Image.Type.Sliced;
          handle1.GetComponent<Image>().sprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(16f, 16f), 200.0f, 0, SpriteMeshType.Tight, new Vector4 (10,10,10,10));
          handle1.transform.SetParent(slidingAreaV.transform);
          slidingAreaV.GetComponent<RectTransform>().anchorMin = new Vector2 (0, 0);
          slidingAreaV.GetComponent<RectTransform>().anchorMax = new Vector2 (1, 1);
          scrollView.GetComponent<ScrollRect>().content = Content.GetComponent<RectTransform>();
          scrollView.GetComponent<ScrollRect>().viewport = Viewport.GetComponent<RectTransform>();
          scrollView.GetComponent<ScrollRect>().horizontalScrollbar = ScrollbarH.GetComponent<Scrollbar>();
          scrollView.GetComponent<ScrollRect>().verticalScrollbar = ScrollbarV.GetComponent<Scrollbar>();
          scrollView.GetComponent<ScrollRect>().horizontalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
          scrollView.GetComponent<ScrollRect>().verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
          scrollView.GetComponent<ScrollRect>().horizontalScrollbarSpacing = -3;
          scrollView.GetComponent<ScrollRect>().verticalScrollbarSpacing = -3;
          ScrollbarH.GetComponent<Scrollbar>().handleRect = handle.GetComponent<RectTransform>();
          ScrollbarV.GetComponent<Scrollbar>().handleRect = handle1.GetComponent<RectTransform>();
          ScrollbarH.GetComponent<Image>().sprite = scrollView.GetComponent<Image>().sprite;
          ScrollbarV.GetComponent<Image>().sprite = scrollView.GetComponent<Image>().sprite;
          ScrollbarV.GetComponent<Image>().type = Image.Type.Sliced;
          ScrollbarV.GetComponent<Scrollbar>().targetGraphic = handle1.GetComponent<Image>();
          ScrollbarV.GetComponent<Scrollbar>().direction = Scrollbar.Direction.BottomToTop;
    }
 }
}