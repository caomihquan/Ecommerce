import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule,HTTP_INTERCEPTORS } from '@angular/common/http';
import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { UnauthorizeModule } from './unauthorize/unauthorize.module';
import { AuthorizeInterceptor } from './interceptors';


@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    AppRoutingModule,
    HttpClientModule,
    UnauthorizeModule
  ],
  providers: [{
    provide:HTTP_INTERCEPTORS,
    useClass:AuthorizeInterceptor,
    multi:true
  }],
  bootstrap: [AppComponent]
})
export class AppModule { }
