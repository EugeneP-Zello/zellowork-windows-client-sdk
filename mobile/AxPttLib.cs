//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5485
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Reflection.AssemblyVersion("1.0.0.0")]
[assembly: System.Windows.Forms.AxHost.TypeLibraryTimeStamp("20.10.2016 5:08:37")]

namespace AxPttLib {
    
    
    [System.Windows.Forms.AxHost.ClsidAttribute("{8316a274-c3ce-46ae-9121-cb8e4080d0db}")]
    [System.ComponentModel.DesignTimeVisibleAttribute(true)]
    [System.ComponentModel.DefaultEvent("SignInStarted")]
    public class AxPtt : System.Windows.Forms.AxHost {
        
        private PttLib.IPtt ocx;
        
        private AxPttEventMulticaster eventMulticaster;
        
        private System.Windows.Forms.AxHost.ConnectionPointCookie cookie;
        
        public AxPtt() : 
                base("8316a274-c3ce-46ae-9121-cb8e4080d0db") {
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(4)]
        public virtual PttLib.NETWORK_STATUS NetworkStatus {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("NetworkStatus", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.NetworkStatus;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(5)]
        public virtual PttLib.ONLINE_STATUS OnlineStatus {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("OnlineStatus", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.OnlineStatus;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("OnlineStatus", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.OnlineStatus = value;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(6)]
        public virtual string Username {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("Username", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.Username;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(7)]
        public virtual string Password {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("Password", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.Password;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(8)]
        public virtual PttLib.IContacts Contacts {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("Contacts", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.Contacts;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(9)]
        public virtual PttLib.INetwork Network {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("Network", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.Network;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(10)]
        public virtual PttLib.ISettings Settings {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("Settings", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.Settings;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(12)]
        public virtual PttLib.IAudioPlayer AudioPlayer {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("AudioPlayer", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.AudioPlayer;
            }
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(21)]
        public virtual PttLib.ICustomization Customization {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("Customization", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.Customization;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(28)]
        public virtual bool VoxActive {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("VoxActive", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.VoxActive;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("VoxActive", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.VoxActive = value;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(29)]
        public virtual string StatusText {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("StatusText", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.StatusText;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("StatusText", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.StatusText = value;
            }
        }
        
        public event System.EventHandler SignInStarted;
        
        public event System.EventHandler SignInSucceeded;
        
        public event IPttEvents_SignInFailedEventHandler SignInFailed;
        
        public event System.EventHandler SignOutStarted;
        
        public event System.EventHandler SignOutComplete;
        
        public event System.EventHandler SignInRequested;
        
        public event IPttEvents_GetCanSignInEventHandler GetCanSignIn;
        
        public event System.EventHandler ContactListChanged;
        
        public event System.EventHandler HistoryChanged;
        
        public event IPttEvents_MessageInBeginEventHandler MessageInBegin;
        
        public event IPttEvents_MessageInEndEventHandler MessageInEnd;
        
        public event IPttEvents_MessageOutBeginEventHandler MessageOutBegin;
        
        public event IPttEvents_MessageOutEndEventHandler MessageOutEnd;
        
        public event IPttEvents_MessageOutErrorEventHandler MessageOutError;
        
        public event IPttEvents_AudioMessageInStartEventHandler AudioMessageInStart;
        
        public event IPttEvents_AudioMessageInStopEventHandler AudioMessageInStop;
        
        public event IPttEvents_PlayerAudioMessageStartEventHandler PlayerAudioMessageStart;
        
        public event IPttEvents_PlayerAudioMessageStopEventHandler PlayerAudioMessageStop;
        
        public event IPttEvents_PlayerAudioMessageProgressEventHandler PlayerAudioMessageProgress;
        
        public virtual void SignIn(string bstrUsername, string bstrPassword, bool bPasswordHash) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("SignIn", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.SignIn(bstrUsername, bstrPassword, bPasswordHash);
        }
        
        public virtual void SignOut() {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("SignOut", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.SignOut();
        }
        
        public virtual void Cancel() {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("Cancel", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.Cancel();
        }
        
        public virtual PttLib.IHistory get_History(string bstrFilter) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("get_History", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            PttLib.IHistory returnValue = ((PttLib.IHistory)(this.ocx.get_History(bstrFilter)));
            return returnValue;
        }
        
        public virtual void ShowSettingsDialog(int lParentWindow) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ShowSettingsDialog", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.ShowSettingsDialog(lParentWindow);
        }
        
        public virtual void ShowAboutDialog(int lParentWindow) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ShowAboutDialog", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.ShowAboutDialog(lParentWindow);
        }
        
        public virtual void ShowFeedbackDialog(int lParentWindow) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ShowFeedbackDialog", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.ShowFeedbackDialog(lParentWindow);
        }
        
        public virtual void ShowPasswordWizard(int lParentWindow) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ShowPasswordWizard", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.ShowPasswordWizard(lParentWindow);
        }
        
        public virtual void BeginMessage(string[] users) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("BeginMessage", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.BeginMessage(users);
        }
        
        public virtual void EndMessage() {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("EndMessage", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.EndMessage();
        }
        
        public virtual void RepeatLastMessage() {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("RepeatLastMessage", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.RepeatLastMessage();
        }
        
        public virtual void BeginMessage2(ref string[] users) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("BeginMessage2", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.BeginMessage2(ref users);
        }
        
        public virtual void UpdateContacts() {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("UpdateContacts", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.UpdateContacts();
        }
        
        public virtual void ShowContacts() {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ShowContacts", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.ShowContacts();
        }
        
        public virtual void OpenHistory(PttLib.IContact pContact) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("OpenHistory", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.OpenHistory(pContact);
        }
        
        public virtual void CloseHistory() {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("CloseHistory", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.CloseHistory();
        }
        
        public virtual void ExpandContact(PttLib.IContact pContact) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ExpandContact", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.ExpandContact(pContact);
        }
        
        public virtual void SelectContact(PttLib.IContact pContact) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("SelectContact", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.SelectContact(pContact);
        }
        
        protected override void CreateSink() {
            try {
                this.eventMulticaster = new AxPttEventMulticaster(this);
                this.cookie = new System.Windows.Forms.AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(PttLib.IPttEvents));
            }
            catch (System.Exception ) {
            }
        }
        
        protected override void DetachSink() {
            try {
                this.cookie.Disconnect();
            }
            catch (System.Exception ) {
            }
        }
        
        protected override void AttachInterfaces() {
            try {
                this.ocx = ((PttLib.IPtt)(this.GetOcx()));
            }
            catch (System.Exception ) {
            }
        }
        
        internal void RaiseOnSignInStarted(object sender, System.EventArgs e) {
            if ((this.SignInStarted != null)) {
                this.SignInStarted(sender, e);
            }
        }
        
        internal void RaiseOnSignInSucceeded(object sender, System.EventArgs e) {
            if ((this.SignInSucceeded != null)) {
                this.SignInSucceeded(sender, e);
            }
        }
        
        internal void RaiseOnSignInFailed(object sender, IPttEvents_SignInFailedEvent e) {
            if ((this.SignInFailed != null)) {
                this.SignInFailed(sender, e);
            }
        }
        
        internal void RaiseOnSignOutStarted(object sender, System.EventArgs e) {
            if ((this.SignOutStarted != null)) {
                this.SignOutStarted(sender, e);
            }
        }
        
        internal void RaiseOnSignOutComplete(object sender, System.EventArgs e) {
            if ((this.SignOutComplete != null)) {
                this.SignOutComplete(sender, e);
            }
        }
        
        internal void RaiseOnSignInRequested(object sender, System.EventArgs e) {
            if ((this.SignInRequested != null)) {
                this.SignInRequested(sender, e);
            }
        }
        
        internal void RaiseOnGetCanSignIn(object sender, IPttEvents_GetCanSignInEvent e) {
            if ((this.GetCanSignIn != null)) {
                this.GetCanSignIn(sender, e);
            }
        }
        
        internal void RaiseOnContactListChanged(object sender, System.EventArgs e) {
            if ((this.ContactListChanged != null)) {
                this.ContactListChanged(sender, e);
            }
        }
        
        internal void RaiseOnHistoryChanged(object sender, System.EventArgs e) {
            if ((this.HistoryChanged != null)) {
                this.HistoryChanged(sender, e);
            }
        }
        
        internal void RaiseOnMessageInBegin(object sender, IPttEvents_MessageInBeginEvent e) {
            if ((this.MessageInBegin != null)) {
                this.MessageInBegin(sender, e);
            }
        }
        
        internal void RaiseOnMessageInEnd(object sender, IPttEvents_MessageInEndEvent e) {
            if ((this.MessageInEnd != null)) {
                this.MessageInEnd(sender, e);
            }
        }
        
        internal void RaiseOnMessageOutBegin(object sender, IPttEvents_MessageOutBeginEvent e) {
            if ((this.MessageOutBegin != null)) {
                this.MessageOutBegin(sender, e);
            }
        }
        
        internal void RaiseOnMessageOutEnd(object sender, IPttEvents_MessageOutEndEvent e) {
            if ((this.MessageOutEnd != null)) {
                this.MessageOutEnd(sender, e);
            }
        }
        
        internal void RaiseOnMessageOutError(object sender, IPttEvents_MessageOutErrorEvent e) {
            if ((this.MessageOutError != null)) {
                this.MessageOutError(sender, e);
            }
        }
        
        internal void RaiseOnAudioMessageInStart(object sender, IPttEvents_AudioMessageInStartEvent e) {
            if ((this.AudioMessageInStart != null)) {
                this.AudioMessageInStart(sender, e);
            }
        }
        
        internal void RaiseOnAudioMessageInStop(object sender, IPttEvents_AudioMessageInStopEvent e) {
            if ((this.AudioMessageInStop != null)) {
                this.AudioMessageInStop(sender, e);
            }
        }
        
        internal void RaiseOnPlayerAudioMessageStart(object sender, IPttEvents_PlayerAudioMessageStartEvent e) {
            if ((this.PlayerAudioMessageStart != null)) {
                this.PlayerAudioMessageStart(sender, e);
            }
        }
        
        internal void RaiseOnPlayerAudioMessageStop(object sender, IPttEvents_PlayerAudioMessageStopEvent e) {
            if ((this.PlayerAudioMessageStop != null)) {
                this.PlayerAudioMessageStop(sender, e);
            }
        }
        
        internal void RaiseOnPlayerAudioMessageProgress(object sender, IPttEvents_PlayerAudioMessageProgressEvent e) {
            if ((this.PlayerAudioMessageProgress != null)) {
                this.PlayerAudioMessageProgress(sender, e);
            }
        }
    }
    
    public delegate void IPttEvents_SignInFailedEventHandler(object sender, IPttEvents_SignInFailedEvent e);
    
    public class IPttEvents_SignInFailedEvent {
        
        public PttLib.CLIENT_ERROR errorCode;
        
        public IPttEvents_SignInFailedEvent(PttLib.CLIENT_ERROR errorCode) {
            this.errorCode = errorCode;
        }
    }
    
    public delegate void IPttEvents_GetCanSignInEventHandler(object sender, IPttEvents_GetCanSignInEvent e);
    
    public class IPttEvents_GetCanSignInEvent {
        
        public bool pbVal;
        
        public IPttEvents_GetCanSignInEvent(bool pbVal) {
            this.pbVal = pbVal;
        }
    }
    
    public delegate void IPttEvents_MessageInBeginEventHandler(object sender, IPttEvents_MessageInBeginEvent e);
    
    public class IPttEvents_MessageInBeginEvent {
        
        public PttLib.IMessage pMessage;
        
        public IPttEvents_MessageInBeginEvent(PttLib.IMessage pMessage) {
            this.pMessage = pMessage;
        }
    }
    
    public delegate void IPttEvents_MessageInEndEventHandler(object sender, IPttEvents_MessageInEndEvent e);
    
    public class IPttEvents_MessageInEndEvent {
        
        public PttLib.IMessage pMessage;
        
        public IPttEvents_MessageInEndEvent(PttLib.IMessage pMessage) {
            this.pMessage = pMessage;
        }
    }
    
    public delegate void IPttEvents_MessageOutBeginEventHandler(object sender, IPttEvents_MessageOutBeginEvent e);
    
    public class IPttEvents_MessageOutBeginEvent {
        
        public PttLib.IMessage pMessage;
        
        public PttLib.IContact pContact;
        
        public IPttEvents_MessageOutBeginEvent(PttLib.IMessage pMessage, PttLib.IContact pContact) {
            this.pMessage = pMessage;
            this.pContact = pContact;
        }
    }
    
    public delegate void IPttEvents_MessageOutEndEventHandler(object sender, IPttEvents_MessageOutEndEvent e);
    
    public class IPttEvents_MessageOutEndEvent {
        
        public PttLib.IMessage pMessage;
        
        public PttLib.IContact pContact;
        
        public IPttEvents_MessageOutEndEvent(PttLib.IMessage pMessage, PttLib.IContact pContact) {
            this.pMessage = pMessage;
            this.pContact = pContact;
        }
    }
    
    public delegate void IPttEvents_MessageOutErrorEventHandler(object sender, IPttEvents_MessageOutErrorEvent e);
    
    public class IPttEvents_MessageOutErrorEvent {
        
        public PttLib.IMessage pMessage;
        
        public PttLib.IContact pContact;
        
        public IPttEvents_MessageOutErrorEvent(PttLib.IMessage pMessage, PttLib.IContact pContact) {
            this.pMessage = pMessage;
            this.pContact = pContact;
        }
    }
    
    public delegate void IPttEvents_AudioMessageInStartEventHandler(object sender, IPttEvents_AudioMessageInStartEvent e);
    
    public class IPttEvents_AudioMessageInStartEvent {
        
        public PttLib.IAudioInMessage pMessage;
        
        public bool pbActivate;
        
        public IPttEvents_AudioMessageInStartEvent(PttLib.IAudioInMessage pMessage, bool pbActivate) {
            this.pMessage = pMessage;
            this.pbActivate = pbActivate;
        }
    }
    
    public delegate void IPttEvents_AudioMessageInStopEventHandler(object sender, IPttEvents_AudioMessageInStopEvent e);
    
    public class IPttEvents_AudioMessageInStopEvent {
        
        public PttLib.IAudioInMessage pMessage;
        
        public IPttEvents_AudioMessageInStopEvent(PttLib.IAudioInMessage pMessage) {
            this.pMessage = pMessage;
        }
    }
    
    public delegate void IPttEvents_PlayerAudioMessageStartEventHandler(object sender, IPttEvents_PlayerAudioMessageStartEvent e);
    
    public class IPttEvents_PlayerAudioMessageStartEvent {
        
        public PttLib.IAudioMessage pMessage;
        
        public IPttEvents_PlayerAudioMessageStartEvent(PttLib.IAudioMessage pMessage) {
            this.pMessage = pMessage;
        }
    }
    
    public delegate void IPttEvents_PlayerAudioMessageStopEventHandler(object sender, IPttEvents_PlayerAudioMessageStopEvent e);
    
    public class IPttEvents_PlayerAudioMessageStopEvent {
        
        public PttLib.IAudioMessage pMessage;
        
        public IPttEvents_PlayerAudioMessageStopEvent(PttLib.IAudioMessage pMessage) {
            this.pMessage = pMessage;
        }
    }
    
    public delegate void IPttEvents_PlayerAudioMessageProgressEventHandler(object sender, IPttEvents_PlayerAudioMessageProgressEvent e);
    
    public class IPttEvents_PlayerAudioMessageProgressEvent {
        
        public PttLib.IAudioMessage pMessage;
        
        public int iProgress;
        
        public IPttEvents_PlayerAudioMessageProgressEvent(PttLib.IAudioMessage pMessage, int iProgress) {
            this.pMessage = pMessage;
            this.iProgress = iProgress;
        }
    }
    
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    public class AxPttEventMulticaster : PttLib.IPttEvents {
        
        private AxPtt parent;
        
        public AxPttEventMulticaster(AxPtt parent) {
            this.parent = parent;
        }
        
        public virtual void SignInStarted() {
            System.EventArgs signinstartedEvent = new System.EventArgs();
            this.parent.RaiseOnSignInStarted(this.parent, signinstartedEvent);
        }
        
        public virtual void SignInSucceeded() {
            System.EventArgs signinsucceededEvent = new System.EventArgs();
            this.parent.RaiseOnSignInSucceeded(this.parent, signinsucceededEvent);
        }
        
        public virtual void SignInFailed(PttLib.CLIENT_ERROR errorCode) {
            IPttEvents_SignInFailedEvent signinfailedEvent = new IPttEvents_SignInFailedEvent(errorCode);
            this.parent.RaiseOnSignInFailed(this.parent, signinfailedEvent);
        }
        
        public virtual void SignOutStarted() {
            System.EventArgs signoutstartedEvent = new System.EventArgs();
            this.parent.RaiseOnSignOutStarted(this.parent, signoutstartedEvent);
        }
        
        public virtual void SignOutComplete() {
            System.EventArgs signoutcompleteEvent = new System.EventArgs();
            this.parent.RaiseOnSignOutComplete(this.parent, signoutcompleteEvent);
        }
        
        public virtual void SignInRequested() {
            System.EventArgs signinrequestedEvent = new System.EventArgs();
            this.parent.RaiseOnSignInRequested(this.parent, signinrequestedEvent);
        }
        
        public virtual void GetCanSignIn(ref bool pbVal) {
            IPttEvents_GetCanSignInEvent getcansigninEvent = new IPttEvents_GetCanSignInEvent(pbVal);
            this.parent.RaiseOnGetCanSignIn(this.parent, getcansigninEvent);
            pbVal = getcansigninEvent.pbVal;
        }
        
        public virtual void ContactListChanged() {
            System.EventArgs contactlistchangedEvent = new System.EventArgs();
            this.parent.RaiseOnContactListChanged(this.parent, contactlistchangedEvent);
        }
        
        public virtual void HistoryChanged() {
            System.EventArgs historychangedEvent = new System.EventArgs();
            this.parent.RaiseOnHistoryChanged(this.parent, historychangedEvent);
        }
        
        public virtual void MessageInBegin(PttLib.IMessage pMessage) {
            IPttEvents_MessageInBeginEvent messageinbeginEvent = new IPttEvents_MessageInBeginEvent(pMessage);
            this.parent.RaiseOnMessageInBegin(this.parent, messageinbeginEvent);
        }
        
        public virtual void MessageInEnd(PttLib.IMessage pMessage) {
            IPttEvents_MessageInEndEvent messageinendEvent = new IPttEvents_MessageInEndEvent(pMessage);
            this.parent.RaiseOnMessageInEnd(this.parent, messageinendEvent);
        }
        
        public virtual void MessageOutBegin(PttLib.IMessage pMessage, PttLib.IContact pContact) {
            IPttEvents_MessageOutBeginEvent messageoutbeginEvent = new IPttEvents_MessageOutBeginEvent(pMessage, pContact);
            this.parent.RaiseOnMessageOutBegin(this.parent, messageoutbeginEvent);
        }
        
        public virtual void MessageOutEnd(PttLib.IMessage pMessage, PttLib.IContact pContact) {
            IPttEvents_MessageOutEndEvent messageoutendEvent = new IPttEvents_MessageOutEndEvent(pMessage, pContact);
            this.parent.RaiseOnMessageOutEnd(this.parent, messageoutendEvent);
        }
        
        public virtual void MessageOutError(PttLib.IMessage pMessage, PttLib.IContact pContact) {
            IPttEvents_MessageOutErrorEvent messageouterrorEvent = new IPttEvents_MessageOutErrorEvent(pMessage, pContact);
            this.parent.RaiseOnMessageOutError(this.parent, messageouterrorEvent);
        }
        
        public virtual void AudioMessageInStart(PttLib.IAudioInMessage pMessage, ref bool pbActivate) {
            IPttEvents_AudioMessageInStartEvent audiomessageinstartEvent = new IPttEvents_AudioMessageInStartEvent(pMessage, pbActivate);
            this.parent.RaiseOnAudioMessageInStart(this.parent, audiomessageinstartEvent);
            pbActivate = audiomessageinstartEvent.pbActivate;
        }
        
        public virtual void AudioMessageInStop(PttLib.IAudioInMessage pMessage) {
            IPttEvents_AudioMessageInStopEvent audiomessageinstopEvent = new IPttEvents_AudioMessageInStopEvent(pMessage);
            this.parent.RaiseOnAudioMessageInStop(this.parent, audiomessageinstopEvent);
        }
        
        public virtual void PlayerAudioMessageStart(PttLib.IAudioMessage pMessage) {
            IPttEvents_PlayerAudioMessageStartEvent playeraudiomessagestartEvent = new IPttEvents_PlayerAudioMessageStartEvent(pMessage);
            this.parent.RaiseOnPlayerAudioMessageStart(this.parent, playeraudiomessagestartEvent);
        }
        
        public virtual void PlayerAudioMessageStop(PttLib.IAudioMessage pMessage) {
            IPttEvents_PlayerAudioMessageStopEvent playeraudiomessagestopEvent = new IPttEvents_PlayerAudioMessageStopEvent(pMessage);
            this.parent.RaiseOnPlayerAudioMessageStop(this.parent, playeraudiomessagestopEvent);
        }
        
        public virtual void PlayerAudioMessageProgress(PttLib.IAudioMessage pMessage, int iProgress) {
            IPttEvents_PlayerAudioMessageProgressEvent playeraudiomessageprogressEvent = new IPttEvents_PlayerAudioMessageProgressEvent(pMessage, iProgress);
            this.parent.RaiseOnPlayerAudioMessageProgress(this.parent, playeraudiomessageprogressEvent);
        }
    }
}
