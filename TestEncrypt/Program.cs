using SDKChriptography;

var encriptador = new SDKEncryptSHA256("abelito");
var claveEncriptada = encriptador.Encrypt("123456");
Console.WriteLine(claveEncriptada);
Console.WriteLine(encriptador.Compare("12345", claveEncriptada));