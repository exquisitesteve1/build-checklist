import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {LoginPageComponent} from './login-page/login-page.component';
import {WelcomeComponent} from './login-page/welcome/welcome.component';
import{UserAdministrationComponent} from './login-page/welcome/navbar/user-administration/user-administration.component'
import{BuildChecklistManagementComponent}from './login-page/welcome/navbar/build-checklist-management/build-checklist-management.component'
import{DashboardComponent}from './login-page/welcome/navbar/dashboard/dashboard.component'

const routes: Routes = [
  {path:'', component:LoginPageComponent},
  {path:'welcome', component:WelcomeComponent},
  {path:'UserAdministration', component:UserAdministrationComponent},
  {path:'BuildChecklistManagement', component:BuildChecklistManagementComponent},
  {path:'Dashboard', component:DashboardComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
