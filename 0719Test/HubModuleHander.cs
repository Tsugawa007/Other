using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Intel.Unite.Common.Command;
using Intel.Unite.Common.Context;
using Intel.Unite.Common.Core;
using Intel.Unite.Common.Manifest;
using Intel.Unite.Common.Module.Common;
using Intel.Unite.Common.Module.Feature.Hub;


namespace _0719Test
{
    public class HubModuleHander : HubFeatureModuleBase
    {
        public HubModuleHander() : base()

        {

        }
        public HubModuleHander(IModuleRuntimeContext runtimeContext) : base(runtimeContext)

        {


        }

        private static readonly ModuleInfo _moduleInfo = new ModuleInfo
        {
            ModuleType = ModuleType.Feature,
            Id = Guid.Parse("6C26AE43-D6DE-4742-8382-AD74C37E5F0A"),
            Name = "0719Test",
            Description = "Test by Maiko",
            Copyright = "Intel corporation 2021",
            Vendor = "Intel Corporation",
            Version = new Version(1, 0, 0, 0),
            SupportedPlatforms = ModuleSupportedPlatform.Mac | ModuleSupportedPlatform.Windows
        };

        public override ModuleInfo ModuleInfo => _moduleInfo;

        private static readonly ManifestOsSet _files = new ManifestOsSet
        {
            Windows = new Collection<ManifestFile>
            {
                new ManifestFile()
                {
                    SourcePath = "0719Test.dll",
                    TargetPath = "0719Test.dll",
                }
            }
        };

        private static readonly ModuleManifest _moduleManifest = new ModuleManifest
        {
            Owner = UniteModuleOwner.Hub,
            ModuleId = _moduleInfo.Id,
            Name = new MultiLanguageString(_moduleInfo.Name),
            Description = new MultiLanguageString(_moduleInfo.Description),
            ModuleVersion = _moduleInfo.Version,
            MinimumUniteVersion = Version.Parse("4.0.0.0"),
            Settings = new Collection<ConfigurationSetting>(),
            Files = _files,
            Installers = new Collection<ManifestInstaller>(),
            EntryPoint = "0719Test.dll",
            ModuleType = _moduleInfo.ModuleType,
        };

        public override ModuleManifest ModuleManifest => _moduleManifest;

        public override string HtmlUrlOrContent => throw new NotImplementedException();

        public override System.Windows.Threading.Dispatcher CurrentUiDispatcher { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

/*
public override ModuleManifest ModuleManifest => throw new NotImplementedException();



public override ModuleInfo ModuleInfo => throw new NotImplementedException();
*/

        public override void HubConnected(HubInfo hubInfo)
        {
            throw new NotImplementedException();
        }

        public override void HubDisconnected(HubInfo hubInfo)
        {
            throw new NotImplementedException();
        }

        public override void HubInfoChanged(HubInfo hubInfo)
        {
            throw new NotImplementedException();
        }

        public override void IncomingMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public override void Load()
        {
            throw new NotImplementedException();
        }

        public override bool OkToSleepDisplay()
        {
            throw new NotImplementedException();
        }

        public override void SessionKeyChanged(KeyValuePair sessionKey)
        {
            throw new NotImplementedException();
        }

        public override void Unload()
        {
            throw new NotImplementedException();
        }

        public override void UserConnected(UserInfo userInfo)
        {
            throw new NotImplementedException();
        }

        public override void UserDisconnected(UserInfo userInfo)
        {
            throw new NotImplementedException();
        }

        public override void UserInfoChanged(UserInfo userInfo)
        {
            throw new NotImplementedException();
        }



    }
}
