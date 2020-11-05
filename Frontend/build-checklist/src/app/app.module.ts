import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginPageComponent } from './login-page/login-page.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { WelcomeComponent } from './login-page/welcome/welcome.component';
import { NavbarComponent } from './login-page/welcome/navbar/navbar.component';
import { UserAdministrationComponent } from './login-page/welcome/navbar/user-administration/user-administration.component';
import { BuildChecklistManagementComponent } from './login-page/welcome/navbar/build-checklist-management/build-checklist-management.component';
import { DashboardComponent } from './login-page/welcome/navbar/dashboard/dashboard.component';
import { UserEditorComponent } from './login-page/welcome/navbar/user-administration/user-editor/user-editor.component';
import { UserAddComponent } from './login-page/welcome/navbar/user-administration/user-add/user-add.component';
// import { ServicesComponent } from './login-page/welcome/services/services.component';


@NgModule({
  declarations: [
    AppComponent,
    LoginPageComponent,
    WelcomeComponent,
    NavbarComponent,
    UserAdministrationComponent,
    BuildChecklistManagementComponent,
    DashboardComponent,
    UserEditorComponent,
    UserAddComponent
    // HttpClientModule,
    // FormsModule
    // ServicesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
