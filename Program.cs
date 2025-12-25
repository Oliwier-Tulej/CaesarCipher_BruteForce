using System;
public class Program
{
    static void Main()
    {
        string text;
        Console.Write("Enter yout cipher: ");
        text = Console.ReadLine();

        text = "epomj ezno yudndve. nuopxuiv diozgdbzixev rkgtrv iv ivnuv xjyudziijnx. vwt fjiotipjrvx rturvidz, rtngde fjy uvyvidv iv: epomj.ezno.yudndve@vyzkxd.do";
        string text2 = "wdcjv gideve nihre d rentvswxwdcgl xiglrmo wdcjvsaerme rmi vsdvuurme wml tvdc xcq pmxiv hyucgl m qeicgl";
        string text3 = "ltpsph qlza zbwly";

        Cipher cipher = new Cipher(text);
        Cipher cipher2 = new Cipher(text2);
        Cipher cipher3 = new Cipher(text3);

        //cipher.Results();
        //cipher.FindPolish();
        //cipher2.FindPolish();
        // cipher3.FindPolish();
    }
}