import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginPageComponent } from './login-page/login-page.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ReactiveFormsModule } from '@angular/forms';
import { WelcomeComponent } from './login-page/welcome/welcome.component';
import { NavbarComponent } from './login-page/welcome/navbar/navbar.component';
import { UserAdministrationComponent } from './login-page/welcome/navbar/user-administration/user-administration.component';
import { BuildChecklistManagementComponent } from './login-page/welcome/navbar/build-checklist-management/build-checklist-management.component';
import { DashboardComponent } from './login-page/welcome/navbar/dashboard/dashboard.component';


@NgModule({
  declarations: [
    AppComponent,
    LoginPageComponent,
    WelcomeComponent,
    NavbarComponent,
    UserAdministrationComponent,
    BuildChecklistManagementComponent,
    DashboardComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
