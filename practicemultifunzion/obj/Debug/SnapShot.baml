   M S B A M L   `   `   `  ����[  WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms  5   	    practicemultifunzion#   practicemultifunzion.SnapShot   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     5   	     � Title$  SnapShot��5   	    � Icon$9 3images\Christmas_Blue_Star_Ornament_PNG_Picture.png��6   $	��590��6U   $	��840��6b    � WindowStartupLocation$ CenterScreen=�6n    � WindowStyle$
 None=�6�    � AllowsTransparency .  ���	#FF292525$��1q�6�    � 
ResizeMode$ NoResize=�6�   ��5      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FFF1F1F1��6   � 5	      $ White��6   	 � Offset$	 0.583Q�6)   � 5
      $ 	#FFF1F1F1��6   $
	 0.87Q�6-   5      .��5      � -   5        
 � 	Resources
 5   
      MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%d  &	        �� 5      " ��6%   .�5      ��  � �� 5      �� 5      " ��6*   .R�5      �� $��border��6%   $��0q�63   #��z��6G   ._�5   "   �� $��Center=�63   $��Center=�6P   5       5      P� 5   "    �@J�IsMouseOver . . �5   &   ��  �@J�Opacity$	 0.8Q�6@   5   #   5      5      5      5       � ColumnDefinitions 5    
   �� 5!      $
��152* �6   �� 5"      $
��150* �6   �� 5#      $
��125* �6   �� 5$      $
��138* �6   �� 5%      $
��138* �6   �� 5&      $
��136* �6    � RowDefinitions 5(   
   �� 5)      $	��75* �6   �� 5*      $��9* �6   �� 5+      $��9* �6   �� 5,      $
��101* �6   �� 5-      $	��96* �6   �� 5.      $
��108* �6   �� 5/      $	��97* �6   �� 50      $	��93* �6   .+�52   
   �� $��1��6   $��1��6$   ���	#FF2E577A61   �� 53   
   $��2��6   $��1��6$   ���	#FF38658B61   �� 54   
   $��3��6   $��1��6$   ���	#FF4A7DA861   �� 55   
   $��4��6   $��1��6$   ���	#FF5891C161   �� 56   
   $��5��6   $��1��6$   ���	#FF5C9DD361   �� 57   
   $��1��6   $��2��6$   $��5��61   ���	#FF89C577$��0,0,0,26q�6V   $��2��6h   �� 58   
   $��2��6   $��Center=�6    $	��316��6=   $��68,10,17,10q�6I   $��3��6^   .��59      �� $��25(�6   $��SemiBold"�6&   ���	#FF514141$��Verdana)�6S   $	��304��6h   $��32��6t   Multifunzion�� 6�   .F�5:      �� $��all in one software��6   ���	#FF6368D1$
��Thin"�6H   $��13(�6Z   $��29��6h   $	��132��6t   5;      6!   5<      �� 5=   
   -   5        $��	RotateImg��5=      $9��3images\Christmas_Blue_Star_Ornament_PNG_Picture.png��6!   $��Right=�6^   $��56��6z   $	��Top=�6�   $��56��6�   $��0,8,56,0q�6�   $��2��6�   �� 5>   
   -   5        $��btn_exit��5>      #��[  6!    � ToolTip$
 Exit��6D   $��5��6S   $��Right=�6d   ���	#FFF1F1F1$��0,6,3,19q�6�   $��35��6�   .��5?      �� $D��>images\074499-simple-red-glossy-icon-alphanumeric-x-styled.png��6   $��44��6\   $��35��6h   6u   5@      �� 5A   
   -   5        $��btn_minimize��5A      $ Minimize��6%   $��5��68   $��Right=�6I   ���	#FFF1F1F1#��[  6|   $��
0,15,35,21q�6�   $��24��6�   .��5B      �� $F��@images\003003-simple-red-glossy-icon-media-a-media292-minus3.png��6   $��14��6^   $��36��6j   6x   5C      �� 5D   
   -   5         ��Name$ btn_home��5D      $
 Home��6#   #��[  62   $��Stretch=�6T   $��Stretch=�6r   ���	#FF423939$��3��6�   .��5E      ��  �� Orientation$ 
Horizontal=�6   $��50��62   .+�5F      �� $��images\20151130142721.png��6   $��40��6;   6H   �� 5G      $�� HOME��6   
�������$��14(�6=   $��Yu Gothic Light)�6K   $��SemiBold"�6h   $	��101��6~   $��0,15,0,0q�6�   6�   5H      5I      �� 5J   
   -   5        $��captureimage��5J      #��[  6%   $ Capture Image��6G   $��2��6_   $��Stretch=�6l   $��Stretch=�6�   ���	#FF423939$��13(�6�   $��Yu Gothic Light)�6�   $��SemiBold"�6�   $��	0,9.1,0,0q�6  $��2��6,  .��5K      �� $ 
Horizontal=�6   .+�5L      �� $4��.images\Photo-Video-Slr-Camera2-Filled-icon.png��6   $��40��6P   $��0,0,0,0q�6[   $��35��6l   �� 5M      $��CAPTURE��6   
�������$��14(�6?   $��Yu Gothic Light)�6M   $��SemiBold"�6j   $	��108��6�   $��0,15,0,0q�6�   $��42��6�   5N      5O      �� 5P   
   -   5        $��	saveimage��5P      #��[  6"   $ 
Save Image��6D   $��0,0.032,0,0q�6Y   $��0��6n   $��4��6~   $��Stretch=�6�   $	��Top=�6�   ���	#FF423939$��96��6�   {�.  .��5Q      �� $ 
Horizontal=�6   .+�5R      �� $ ��images\save-256-000000.png��6   $��32��6<   $��34��6G   �� 5S      $��
SAVE IMAGE��6   
�������$
��13.3(�6A   $��Yu Gothic Light)�6Q   $��SemiBold"�6n   $	��107��6�   $��0,15,0,0q�6�   $��42��6�   5T      5U      �� 5V   
   -   5        $ 	btn_exit2��5V      #��[  6%   $
 Exit��6G   $��	0,0.1,0,0q�6V   $��0��6i   $��7��6y   $��Stretch=�6�   $��Stretch=�6�   ���	#FF423939.��5W      �� $ 
Horizontal=�6   .+�5X      �� $/��)images\Delete_remove_close_exit_trash.png��6   $��32��6K   $��36��6V   6d   �� 5Y      $�� EXIT��6   
�������$��14(�6;   $��Yu Gothic Light)�6I   $��SemiBold"�6f   $��32��6|   $	��102��6�   6�   5Z      5[      �� 5\   
   -	   5        $ 	btn_About��5\      #��[  6$   $ About��6F   $��	0,0.1,0,0q�6V   $��6��6i   $��Stretch=�6v   $	��Top=�6�   ���	#FF423939$��97��6�   .��5]      �� $ 
Horizontal=�6   .+�5^      �� $��images\20151130140544.png��6   $��35��6;   6H   �� 5_      $�� ABOUT��6   
�������$��14(�6>   $��Yu Gothic Light)�6L   $��SemiBold"�6i   $��34��6   $	��105��6�   6�   5`      5a      �� 5b   
   -
   5        $ btn_snapshot��5b      #��[  6'   $
 Help��6I   $��	0,0.1,0,0q�6X   $��0��6k   $��5��6{   $��Stretch=�6�   $��Stretch=�6�   ���	#FF423939.��5c      �� $ 
Horizontal=�6   .+�5d      �� $��images\20151130140744.png��6   $��38��6;   6H   �� 5e      $�� HELP��6   
�������$��14(�6=   $��Yu Gothic Light)�6K   $��SemiBold"�6h   $��34��6~   $	��106��6�   6�   5f      5g      7  1System.Windows.Forms.Integration.WindowsFormsHost  5h   
   $��Stretch=�6   $��Stretch=�69   $��1��6U   $��3��6e   $��5��6r   $��35,93,23,74q�6�   $��5��6�      Child. 5i      %   System.Windows.Forms.PictureBox  -   5        pictureBox1��   SizeMode$
 Zoom=�5i   1   5j      �� 5k   
   $ ��Screen Capture Or SnapShot��6   $��16(�65   $��SemiBold"�6C   ���	#FF514141$��Verdana)�6p   $��2��6�   $
��Left=�6�   $��42,5,0,0q�6�   $��3��6�   $	��Top=�6�   $	��275��6�   $��40��6�   $��3��6�   �� 5l   
   $!��(Capture then save in .jpg)��6   $��11(�66   $��Normal"�6D   
�������$��Verdana)�6k   $��3��6�   $
��Left=�6�   $��	73,35,0,0q�6�   $��3��6�   $	��Top=�6�   $	��180��6�   $��2��6�   $��23��6  �� 5m   
   $��/* Capture Image */��6   $��14(�6.   $��Normal"�6<   ���	#FF9CBB6F$��Verdana)�6g   $��4��6|   $
��Left=�6�   $��
101,56,0,0q�6�   $��7��6�   $	��Top=�6�   $��2��6�   $	��162��6�   �� 5n   
   -   5         ��Name$ txt_Help��5n      $����1. Capture Screen by clicking left side 'CAPTURE' button .                                2. Now save the image by clicking 'SAVE IMAGE' button.                                   3. The image will be saved in the location where you have saved .��6&   $��15(�5p   Q   $��SemiBold"�6_   
���   �$��Tahoma)�6�   $��1��6�   $
��Left=�6�   $��58,0,0,0q�6�   $��4��6�   $
��Wrap=�6�   $	��Top=�6�   $��3��6  $	��183��6&  $��2��63  $	��251��6D  $y�Hidden=�6P  5r      5s      5t      