   M S B A M L   `   `   `  ����K  GDiplomeProektWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:DiplomeProektWPFDiplomeProektWPF  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   !    DiplomeProektWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:DiplomeProektWPF     5   	   9system&clr-namespace:System;assembly=mscorlib     5   	     � Title$  
MainWindow��5	   	   $	��800��6   $	��960��6)    � 	Resources 5
      .  (DiplomeProektWPF.BoolVisibilityConverter   InputToVisibility  messageBorder �� 
TargetType �� Property �� Value �� CornerRadius  Link  
NumberLink  TextFont  ButtonTemplate �� 
TargetType �� Triggers P� Property	 P� Value
 �� 
TargetName  FindAreaStyle `� 	Converter �� ElementName �� Path ��Name �� TextAlignment  
LastButton  TweetColumMassenge �� Orientation
 � Tag J� Clip @� Center @� RadiusX @� RadiusY �� TextDecorations �Name(   "DiplomeProektWPF.NavigationService   Text��%�  &	        &	      '�� �     &	 �     &	 ?    &	     &	 {    &	 �    7   &	 x    &	 �    7    5   
   6(   �� 5   
   " ��6&   .�5      ��  � �� 5      �� 5      .R�5      �� $��1q�6!   $ 	14,14,0,0��65   5      5      5      �� 5   
   " ��6   .�5      ��  � �� �#0083fe6+   5      �� 5   
   .�5      ��  � �� �#0083fe63   5      �� 5   
   " ��6#   .�5      ��  � ��$ Center=�64   �� 5       � ��$ Center=�62   �� 5       � ��$ Roboto)�6+   �� 5        � �� �#4e5f6f6+   5!      �� 5"   
   " ��6!   .�5#      ��  � �� �#4e5f6f6+   �� 5$       � ��$ Roboto)�6+   5%      �� 5&   
   " ��61   .R�5'      �� $��border��6P   ���#0083fe$��1q�6+   $ 3��6?   ���#0083fe._�5(      �� ��. 6A   5)       5*      P� 5+       � ��	 . . �5,      �� $
 border��6    � �� �#90afc56Z   5-      5/      �� 50   
   " ��6&   .�51      ��  �@��TextAlignment$
 Left=�6.   �� 52       � ��$ Center=�69   �� 53       � �� 54      �� 55      " ��6&   .R�56      �� $ 3��6!   $��1q�62   
�������._�57      � .+�58   "   �� $��textBlockStart��6-   $
��Left=�6C   $��Center=�6^   $��18,0,0,0q�6y   $��Roboto)�6�   $��14(�6�   ���#8998a5�� 59   &   .�6*   Введите63    �� 5:   &   $��Italic$�6*   .�6=   #хештег6F    �� 5;   &   .�6*   или6/    �� 5<   &   $��Italic$�6*   .�6=   	@имя6C   y�5=   &   `� 5>   *   8   .1�5?   .   �� $ 	inputText��66   $ Text.IsEmpty�6N   �� 5@   .   $ 	inputText��66   $ 	IsFocused�6N   5A   +   5C   #   �� 5D   "   $ 	inputText��6*   -   5        
������ 
�������$
 Left=�5D   �   $��18,0,0,0q�6�   $��14(�6�   $��0q�6�   $	��325��6�   $
��Left=�6�   $��Center=�6�   5E      5F      5G      5I      5J      �� 5K   
   " ��6-   .R�5L      �� $��border��6X   ���#8998a5$��1q�6+   $ 	0,0,14,14��6?   ���#eaeef2._�5M      �� ��. 6A   5N       5O      P� 5P       � ��	 . . �5Q      �� $
 border��6    � �� �#eaeef26Z   5R      5T      �� 5U   
   .R�5V      �� $��80��6   $	��573��6!   $��0,0,0,0q�6-   $��0,0,0,1q�6?   ���#a2aeba._�5W      �� $ 
Horizontal=�6   .+�5X      �� $��TweetsUserImage��6   -   5        $��40��5X   ~   $��40��6�   $
��Fill=�6�   $��Center=�6�   $��Center=�6�   $��
17,17,0,17q�6�    63   �� $ User.ProfileImageUrl� 5Y      @� 5Z      $ 20,20&�6.   $ 20Q�6=   $ 20Q�6J   5\      �� 5]      $ Vertical=�6!   .+�5^      �� $ 
Horizontal=�6%   $��	12,20,0,0q�6>   .+�5_      �� $��14(�6(   $
��Bold"�66   8��  ��6j   �� $ 	User.Name��� 5a      $��25,0,0,0q�6)   �� 5b   "   $
 none{�6,   .�6D   .�5c   $   �� $��12(�6(   ���#0083fe.�6K   @6N   �� 6S   $ RunINeed��6z   -   5        $��12(�5c   W   ���#0083fe�6�   �� $ User.ScreenName�5d   #   5e      �� 5f      $��TweetsUserTimeTextBlock��6(   $��Right=�6G   $��	150,0,0,0q�6c   ���#a2aeba��6�   �� $ CreatedDate�5g      �� 5h      $��TweetsUserTweetTextBlock��6W   $��12,5,0,0q�6w   $��13(�6�   ���#8998a5$��WrapWithOverflow=�6�   $	��490��6�    6$   �� $
 Text�5j      5k      5l      5m      5n      5o      .��5p      (�  (� Stretch$
 Fill=�6   .��5q   
   � -   5         �Name$ GridMainWindow��5q      
������� � ColumnDefinitions 5r      �� 5s      $
��Auto �6#   �� 5t      $
��Auto �6#    � RowDefinitions 5v   
   �� 5w      .+�5y      �� -   5         ��Name$ StackPanelUser��5y      $��0��6-   $	��370��6=   $	��746��6I   $��10q�6W   $ 14��6d   
�������._�5z      �  5{      �� 5|      $
��1.5* �6(   �� 5}      $
��1.5* �6(   �� 5~      $��1* �6(   �� 5      $��4* �6(    5�      �� 5�      .+�5�      �� $��0��6   
���   �$ 	14,14,0,0��6=   �� 5�      -   5        $��ProfileImageMain��5�      $��2��64   $	��120��6E   $	��120��6Q   $��Center=�6^   $��Images/testPhoto.png��6y   $
��Fill=�6�    5�      @� 5�      $ 60,60&�6.   $ 60Q�6=   $ 60Q�6J   5�      �� 5�      $��1��6!   .+�5�      �� -   5        $��ProfileTextBlockName��5�   $   $��20(�6@   $
��Bold"�6N   $��Center=�6`   #��[ 6}   $��75q�6�   �� 5�      -   5        $��ProfileTextBlockNickName��5�   $   $��16(�6D   $��Roboto)�6R   $��Center=�6f   $��	0,-75,0,0q�6�   �� 5�      -	   5        $ ProfileBlockNickHyperlink��5�   (   $
 none{�6I   .�6`   .�5�   "   �� .�6&   @6)   �� 6.   -
   5        $ RunNameHyperLink��5�   G   ���#0083fe.�6`   $�asdasd��5�   @   .�5�   #   5�      5�      5�      � 5�      $��2��6   ���#eaeef2 5�      �� 5�      �� 5�      .+�5�      �� $��0��6!   $��0,1,1,1q�61   ���#8998a5._�5�      �� $��0��6)   .+�5�   "   �� -   5        $��FollowersTextBlockCount��5�   ,   #��[ 6K   $��16(�6o   $
��Bold"�6}   $��
15,25,15,2q�6�   12,4906�   �� 5�   "   #��[ 6,   $��14(�6P   Читают6f   5�      5�      �� 5�      $��1��6!   $��0,1,0,1q�61   ���#a2aeba._�5�      �� $��1��6)   .+�5�   "   �� -   5        $��FollowingTextBlockCount��5�   ,   #��[ 6K   $��16(�6o   $
��Bold"�6}   $��
15,25,15,2q�6�   2,4906�   �� 5�   "   #��[ 6,   $��14(�6P   Читает6f   5�      5�      5�      �� 5�      $��3��6!   .+�5�      �� $��44��6!   ���#66d99f$��0,15,0,0q�6B   $��Roboto)�6T   $��16(�6h   $
��Bold"�6v   .��6�   Читать6�   �� 5�      $
��Left=�6%   $��18(�6@   $
��Bold"�6N   #��[ 6`   $$��Актуальные темы:��6�   $��20,20q�6�   �� 5�      -   5        $��	TrendList��5�   '   $	��260��68   $��20,-20,20,0q�6E   $��14(�6Z   #��[ 6h   ��5�      �� 5�   "   .R�5�   &   �� $��3q�60   �� 5�   *   $
 none{�64   .�6K   .�5�   .   �� -   5        $��14(�5�   M   ���#0083fe�62   �� $
 Name�6p   5�   +   5�   '   5�   #   5�      5�      5�      5�      �� 5�      -   5        $ StackPanelFind��5�      $��1��6-   $	��573��6=   $	��113��6I   $	��Top=�6V   $��10,14,10,10q�6n   $ 14��6�   
�������._�5�      �� $ 
Horizontal=�6   .+�5�      �� -   5         ��Name$ BoldFInd��5�       $��
Поиск��62   $
��Bold"�6?   $��	25,20,0,0q�6Q   $��24��6d   $	��Top=�6p   $��16(�6�   #��[ 6�   �� 5�      -   5        $ FindArea��5�      $��44��61   $	��360��6=   $��
-48,25,0,0q�6I   $
��Left=�6]   #��[ 6x   .��6�   5�      �� 5�      -   5         ��Name$ 
FindButton��5�      $��60��61   $��44��6<   $��0,25,0,0q�6H   #��[ 6s   .��5�      �� .+�5�      �� $��Images/searchicon.png��6$   $
��Fill=�6C   $��13q�6R   $��20��6^   $��20��6j   5�      5�      �� 5�      -   5        $ 
HomeButton��5�      $��44��61   $	��105��6=   $��	10,25,5,0q�6I   #��[ 6u   .��5�      �� $ 
Horizontal=�6%   
�������.+�5�      �� $��
Домой��6(   $��16(�65   $��Roboto)�6C   ���#0083fe$��Center=�6l   $��Center=�6�   $��	10,10,7,8q�6�   �� 5�      $��Images/homeicon.png��6$   $��Center=�6B   $��Center=�6]   $��	3,8,10,10q�6z   $��20��6�   $��20��6�   5�      5�      5�      5�      �� 5�      -   5        $ StackPanelMassenge��5�      $��1��61   $	��573��6A   $	��625��6M   $ 14��6Z   $��10,136,10,14q�6l   
�������._�5�      �� .+�5�      �� -   5          ��Name$  itemControlTweets��5�   #   #��[ 6>   5�      �� 5�      -   5        $��40��5�      #��[ 6)   .��5�      �� #��[ 6$   $��13(�6F   $
��Bold"�6T   $��Center=�6f   $��Center=�6�   ���#0083fe$2��,Загрузить другие записи��6�   5�      5�      5�      5�      5�      5�      