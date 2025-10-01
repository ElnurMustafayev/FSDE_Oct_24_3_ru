using FluentFTP;

// link: ftp://ftp.uni-kl.de/pub/linux/gentoo/distfiles/1d/cat-soltys.png

using FtpClient client = new FtpClient("ftp://ftp.uni-kl.de");

client.Connect();

client.DownloadFile(
    localPath: "cat.png",
    remotePath: "/pub/linux/gentoo/distfiles/1d/cat-soltys.png"
);

string[] filenames = client.GetNameListing("/pub/linux/gentoo/distfiles/1d/");