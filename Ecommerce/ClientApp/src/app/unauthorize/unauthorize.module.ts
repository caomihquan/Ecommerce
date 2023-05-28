import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UnauthorizeRoutingModule } from './unauthorize-routing.module';
import { LoginComponent } from './login/login.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HomeComponent } from './home/home.component';


@NgModule({
  declarations: [
    LoginComponent,
    HomeComponent
  ],
  imports: [
    CommonModule,
    UnauthorizeRoutingModule,
    ReactiveFormsModule,
    FormsModule
  ]
})
export class UnauthorizeModule { }
