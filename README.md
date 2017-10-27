# Layout Compression

**Layout Compression** allows you to specify unnecessary nesting and allows Xamarin.Forms to opt-out of creating that layout view.

Using [Xamarin Inspector](https://developer.xamarin.com/guides/cross-platform/inspector/) we can view the UI layering of a Xamarin.Forms page. In this example we will use a Xamarin.Forms version of the **Netflix** App to see how much we are able to flatten the UI of a App.

<img src="images/netflix-profile-android.png" alt="Choose Profile" Width="210" /> <img src="images/netflix-home-android.png" alt="Home" Width="210" /> <img src="images/netflix-menu-android.png" alt="Main Menu" Width="210" /> <img src="images/netflix-movie-android.png" alt="Movie Detail" Width="210" />

### Profile View

##### Default

<img src="images/default-profile.png" Width="600" />

##### Layout Compression

<img src="images/layout-compression-profile.png" Width="600" />

- Default: 71 Renderers.
- Layout Compression: 51 Renderers.

28% off

### Home View

##### Default

<img src="images/default-home.png" Width="600" />

##### Layout Compression

<img src="images/layout-compression-home.png" Width="600" />

- Default: 223 Renderers.
- Layout Compression: 169 Renderers.

24% off

### Detail View

##### Default

<img src="images/default-detail.png" Width="600" />

##### Layout Compression

<img src="images/layout-compression-detail.png" Width="600" />

- Default: 296 Renderers.
- Layout Compression: 229 Renderers.

22% off

## Feedback

Please use [GitHub issues](https://github.com/jsuarezruiz/layout-compression-sample/issues) for questions or comments.

## Copyright and license

Code released under the [MIT license](https://opensource.org/licenses/MIT).