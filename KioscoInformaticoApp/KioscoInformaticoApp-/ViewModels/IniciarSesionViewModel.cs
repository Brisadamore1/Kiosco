﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using KioscoInformaticoApp_.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformaticoApp_.ViewModels
{
    public partial class IniciarSesionViewModel : ObservableObject
    {
        public readonly FirebaseAuthClient _clientAuth;
        private FileUserRepository _userRepository;
        private UserInfo _userInfo;
        private FirebaseCredential _firebaseCredential;

		[ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(IniciarSesionCommand))]
        private string mail;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(IniciarSesionCommand))]
        private string password;

        private bool recordarContraseña;
		
		public IRelayCommand IniciarSesionCommand { get; }
        public IRelayCommand RegistrarseCommand { get; }
        public IniciarSesionViewModel()
        {
            _clientAuth = new FirebaseAuthClient(new FirebaseAuthConfig()
            {
                ApiKey = "AIzaSyCWuLtoHlo41oPDEpedEqoXD_qmwS6x4aY",
                AuthDomain = "kioscoinformatico-943c1.firebaseapp.com",
                Providers = new Firebase.Auth.Providers.FirebaseAuthProvider[]
                {
                    new EmailProvider()
                }
            });
            _userRepository = new FileUserRepository("KioscoInformatico");
            ChequearSiHayUsuarioAlmacenado();
            IniciarSesionCommand = new RelayCommand(IniciarSesion, PermitirIniciarSesion);
            RegistrarseCommand = new RelayCommand(Registrarse);

        }

        private async void Registrarse()
        {
            await Shell.Current.GoToAsync("Registrarse");
        }

        private async void ChequearSiHayUsuarioAlmacenado()
        {
            if (_userRepository.UserExists())
            {
                (_userInfo, _firebaseCredential) = _userRepository.ReadUser();

                var shellKiosco = (KioscoShell)App.Current.MainPage;
                shellKiosco.EnableAppAfterLogin();
            }
        }
        public bool PermitirIniciarSesion()
        { 
            return !string.IsNullOrEmpty(Mail) && !string.IsNullOrEmpty(Password);
        }
        private async void IniciarSesion()
        {
            try
            {
                var userCredential = await _clientAuth.SignInWithEmailAndPasswordAsync(mail, password);
                if (userCredential.User.Info.IsEmailVerified == false)
                {
                    await Application.Current.MainPage.DisplayAlert("Inicio de sesión", "Debe verificar su correo electrónico", "Ok");
                    return;
                }

                if (recordarContraseña)
                {
                    _userRepository.SaveUser(userCredential.User);
                }
                else
                {
                    _userRepository.DeleteUser();
                }

                var shellKiosco = (KioscoShell)App.Current.MainPage;
                shellKiosco.EnableAppAfterLogin();

            }
            catch (Exception error)
            {
                await Application.Current.MainPage.DisplayAlert("Inicio de sesión", "Ocurrió un problema:" + error.Message, "Ok");

            }
            //WeakReferenceMessenger.Default.Send(new Message("AbrirAppShell"));
            
        }
    }
}
