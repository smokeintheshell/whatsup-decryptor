# WhatsUp Gold Password Decryptor
C# project for decrypting Progress WhatsUp Gold passwords
---
v0.1 is essentially a direct rip of the code Shubham Shah wrote in the article linked below

The exe available from [Releases](https://github.com/smokeintheshell/whatsup-decryptor/releases) is a standalone .NET 5 executable with the necessary dlls compiled into the final binary

Progress WhatsUp Gold offers a free 2 week trial from their website. Unfortunately, older versions are not publicly available

---
## TODO
- [ ] v0.2 add commandline arguments to read passwords from a file
- [ ] Add my research notes
- [ ] Reflective Assembly?
- [ ] Release
---
## Primary code source and research credit to Shubham Shah:
- https://twitter.com/infosec_au
- https://blog.assetnote.io/2022/06/09/whatsup-gold-exploit/
## Additional Ref:
[Metasploit Post Module Doc](https://github.com/rapid7/metasploit-framework/blob/master/documentation/modules/post/windows/gather/credentials/whatsupgold_credential_dump.md)
[Metasploit Post Module](https://github.com/rapid7/metasploit-framework/blob/master/modules/post/windows/gather/credentials/whatsupgold_credential_dump.rb)

### Disclosure
I'm not a developer and I'm still fairly new to C#. I just make shit work